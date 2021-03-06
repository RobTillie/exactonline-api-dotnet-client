﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using ExactOnline.Client.Models;
using ExactOnline.Client.Sdk.Delegates;
using ExactOnline.Client.Sdk.Helpers;
using ExactOnline.Client.Sdk.Interfaces;

namespace ExactOnline.Client.Sdk.Controllers
{

	/// <summary>
	/// Class for managing entity Objects (Read, Get, Update & Delete)
	/// </summary>
	public class Controller<T> : IController<T>, IEntityManager where T : class
	{
		private readonly GetEntityController _entityControllerDelegate;
		public ManagerForEntity GetManagerForEntity;
		private readonly Dictionary<string, object> _entityControllers;
		private readonly IApiConnection _conn;
		private readonly string _keyname;
		private string _expandfield;

		/// <summary>
		/// Create new instance of the controller
		/// </summary>
		public Controller(IApiConnection conn)
		{
			if (conn == null) { throw new ArgumentException("Instance of type APIConnection cannot be null"); }

			// Instantiate the class variables
			_entityControllers = new Dictionary<string, object>();
			_conn = conn;

            // Set keyname of the entity (name of the field that is used to identify)
            var attributes = typeof(T).GetTypeInfo().GetCustomAttributes().Where(x => x.GetType() == typeof(DataServiceKeyAttribute)).Select(a => a); //DataServiceKey
            
			// Find unique value of entity
			var enumerable = attributes as IList<Attribute> ?? attributes.ToList();
			if (!enumerable.Any())
			{
				throw new Exception("Cannot find 'DataServiceKey' field. This entity cannot be managed by the Controller");
			}
			var key = (DataServiceKeyAttribute)enumerable.First();
			_keyname = key.DataServiceKey;
			_entityControllerDelegate = GetEntityController;
		}

		/// <summary>
		/// Returns if the specified entity is managed by the controller
		/// </summary>
		public Boolean IsManagedEntity(object entity)
		{
			return _entityControllers.ContainsKey(GetIdentifierValue(entity));
		}

		/// <summary>
		/// Returns the number of entities of the current type
		/// </summary>
		public async Task<int> CountAsync()
		{
			return await _conn.CountAsync();
		}

		/// <summary>
		/// Gets specific collection of entities
		/// </summary>
		/// <param name="query">oData query</param>
		/// <returns>List of entity Objects</returns>
		public async Task<List<T>> GetAsync(string query)
		{
            // Get the response and convert it to a list of entities of the specific type

            var response = await _conn.GetAsync(query);
			var jsonArray = await ApiResponseCleaner.GetJsonArrayAsync(response);

			var rc = new EntityConverter();
			var entities = rc.ConvertJsonArrayToObjectList<T>(jsonArray);

			// If the entity isn't managed already, register to managed entity collection
			foreach (var entity in entities)
			{
				AddEntityToManagedEntitiesCollection(entity);
			}

            return entities;
		}

		/// <summary>
		/// Get entity using specific GUID
		/// </summary>
		/// <param name="guid">Global Unique Identifier of the entity</param>
		/// <param name="parameters">parameters</param>
		/// <returns>Entity if exists. Null if entity not exists.</returns>
		public async Task<T> GetEntityAsync(string guid, string parameters)
		{
			if (guid.Contains("}") || guid.Contains("{"))

            {
				throw new Exception("Bad Guid: Guid cannot contain '}' or '{'");
			}

			// Convert the resonse to an object of the specific type
			var response = await _conn.GetEntityAsync(_keyname, guid, parameters);
			var jsonObject = await ApiResponseCleaner.GetJsonObjectAsync(response);
			var ec = new EntityConverter();
			var entity = ec.ConvertJsonToObject<T>(jsonObject);

			// If entity isn't managed already, add entity to EntityController
			AddEntityToManagedEntitiesCollection(entity);
			return entity;
		}

		private Boolean IsCreateable(T entity)
		{
            var actions = (SupportedActionsSDK)typeof(T).GetTypeInfo().GetCustomAttribute(typeof(SupportedActionsSDK));
			if (actions != null)
			{
				return actions.CanCreate;
			}
			return false;
		}

		/// <summary>
		/// Creates an entity in Exact Online
		/// </summary>
		/// <param name="entity">Entity to create</param>
		/// <returns>True if succeed</returns>
		public async Task<T> CreateAsync(T entity)
		{
			if (!IsCreateable(entity)) throw new Exception("Cannot create entity. Entity does not support creation. Please see the Reference Documentation.");

			// Get Json code
			var created = false;
			var converter = new EntityConverter();
			var emptyEntity = Activator.CreateInstance<T>();
			var json = await converter.ConvertObjectToJsonAsync(emptyEntity, entity, _entityControllerDelegate);

			// Send to API
			var response = await _conn.PostAsync(json);
			if (!response.Contains("error"))
			{
				created = true;

				// Set values of API in account entity (to ensure GUID is set)
				var jsonObject = await ApiResponseCleaner.GetJsonObjectAsync(response);
				var ec = new EntityConverter();
				entity = ec.ConvertJsonToObject<T>(jsonObject);

				// Try to add the entity to the managed entities collections
				if (!AddEntityToManagedEntitiesCollection(entity))
				{
					throw new Exception("This entity already exists");
				}

				// Get entity with linked entities (API Response for creating does not return the linked entities)
				entity = await GetEntityAsync(GetIdentifierValue(entity), _expandfield);
			}
			return created ? entity : null;
		}

		private Boolean IsUpdateable(T entity)
		{
			var actions = (SupportedActionsSDK)typeof(T).GetTypeInfo().GetCustomAttribute(typeof(SupportedActionsSDK));
			if (actions != null)
			{
				return actions.CanUpdate;
			}
			return false;
		}

		/// <summary>
		/// Updates an entity in Exact Online
		/// </summary>
		/// <param name="entity">Entity to update</param>
		/// <returns>True if succeeded</returns>
		public async Task<bool> UpdateAsync(T entity)
		{
			if (entity == null)
			{
				throw new ArgumentException("Controller Update: Entity cannot be null");
			}

			// Check if entity can be updated
			if (!IsUpdateable(entity)) throw new Exception("Cannot update entity. Entity is not updateable. Please see the Reference Documentation.");

            var entityIdentifier = GetIdentifierValue(entity);
            if (!_entityControllers.ContainsKey(entityIdentifier))
                throw new Exception("Entity identifier value not found");

            var associatedController = (EntityController)_entityControllers[entityIdentifier];
			
			return await associatedController.UpdateAsync(entity);
		}

		private Boolean IsDeleteable(T entity)
		{
			var actions = (SupportedActionsSDK)typeof(T).GetTypeInfo().GetCustomAttribute(typeof(SupportedActionsSDK));
			if (actions != null)
			{
				return actions.CanDelete;
			}
			return false;
		}

		/// <summary>
		/// Deletes an entity from Exact Online
		/// </summary>
		/// <param name="entity"></param>
		/// <returns>True if succeeded</returns>
		public async Task<bool> DeleteAsync(T entity)
		{
			if (entity == null)
			{
				throw new ArgumentException("Controller Delete: Entity cannot be null");
			}
	
			// Check if entity can be deleted
			if (!IsDeleteable(entity)) throw new Exception("Cannot delete entity. Entity does not support deleting. Please see the Reference Documentation.");

			// Delete entity
			var entityIdentifier = GetIdentifierValue(entity);
            if (!_entityControllers.ContainsKey(entityIdentifier))
                throw new Exception("Entity identifier value not found");

            var associatedController = (EntityController)_entityControllers[entityIdentifier];

			var returnValue = false;
			if (await associatedController.DeleteAsync())
			{
				returnValue = true;
				_entityControllers.Remove(entityIdentifier);
			}
			return returnValue;
		}

		/// <summary>
		/// Get the unique value of the entity
		/// </summary>
		public string GetIdentifierValue(object entity)
		{
			if (_keyname.Contains(","))
			{
				throw new Exception("Currently the SDK doesn't support entities with a compound key.");				
			}

			return entity.GetType().GetRuntimeProperty(_keyname).GetValue(entity).ToString();
		}		

		/// <summary>
		/// Adds an associated intance of the EntityController class to the _controllers if the entity is not yet managed 
		/// </summary>
		public Boolean AddEntityToManagedEntitiesCollection(object entity)
		{
			var returnValue = false;
			var entityIdentifier = GetIdentifierValue(entity);
			if (!_entityControllers.ContainsKey(entityIdentifier))
			{
				var newController = new EntityController(entity, _keyname, GetIdentifierValue(entity), _conn, _entityControllerDelegate);
				_entityControllers.Add(entityIdentifier, newController);

				returnValue = true;

				// Get linked entity fields
				var linkedEntityFields = from property in entity.GetType().GetRuntimeProperties()
				                         let ns = property.GetValue(entity) == null ? null : property.GetValue(entity).GetType().Namespace
				                         where ns != null && ((property.GetValue(entity) != null)
										 && (ns.Contains("System.Collections.Generic")))
										 select property.GetValue(entity);

				// Get associated controller & registrate entity
				foreach (var field in linkedEntityFields)
				{
					foreach (var linkedEntity in (IEnumerable)field)
					{
						if (GetManagerForEntity != null)
						{
							var controller = GetManagerForEntity(linkedEntity.GetType());
							controller.AddEntityToManagedEntitiesCollection(linkedEntity);
						}
						else
						{
							throw new Exception("Cannot registrate linked entity: Specific delegate is not set.");
						}
					}
				}
			}
			return returnValue;
		}

		public EntityController GetEntityController(string guid)
		{
            if (!_entityControllers.ContainsKey(guid))
                return null;

			return (EntityController)_entityControllers[guid];
		}

		/// <summary>
		/// Registrates a linked entity field so the Controller knows the field to Expand
		/// </summary>
		public void RegistrateLinkedEntityField(string fieldname)
		{
			_expandfield = fieldname;
		}

		/// <summary>
		/// Method for returning the correct EntityController
		/// This method is used as a delegate, so that ExactOnlineJsonConverter
		/// knows the associated EntityController of a Linked Entity so it can perform
		/// methods on the EntityController to see if the entity is updated
		/// </summary>
		public EntityController GetEntityController(object o)
		{
			var associatedController = GetManagerForEntity(o.GetType());
			var id = associatedController.GetIdentifierValue(o);
			EntityController ec = associatedController.GetEntityController(id);
			return ec;
		}

	}
}
