﻿using System;
using System.Collections;
using System.Reflection;
using ExactOnline.Client.Sdk.Delegates;
using ExactOnline.Client.Sdk.Helpers;
using ExactOnline.Client.Sdk.Interfaces;
using System.Threading.Tasks;

namespace ExactOnline.Client.Sdk.Controllers
{

	/// <summary>
	/// Controls the state of an entity to create the functionality for only sending altered fields to the API
	/// </summary>
	public class EntityController
	{
		private readonly IApiConnection _connection;
		private readonly GetEntityController _entityControllerDelegate;
		private readonly string _keyName; // Name of the field that identifies the entity
		private readonly string _identifier; // Value of the field that identifies the entity 
		public object OriginalEntity { get; private set; }

		/// <summary>
		/// Creates an instance of EntityController
		/// </summary>
		/// <param name="entity">An instance of an Entity that must be managed</param>
		/// <param name="keyName">Name of the keyname field of the entity (mostly ID)</param>
		/// <param name="identifier">Name of the identifier field of the entity (mostly ID)</param>
		/// <param name="connection">Instance of IApiConnection to connect to the specific part of the API</param>
		/// <param name="entityControllerDelegate">Delegate that gets the entity controller</param>
		public EntityController(object entity, string keyName, string identifier, IApiConnection connection, GetEntityController entityControllerDelegate)
		{
			_connection = connection;
			_keyName = keyName;
			_identifier = identifier;
			OriginalEntity = Clone(entity);
			_entityControllerDelegate = entityControllerDelegate;
		}

		/// <summary>
		/// Indicates if an entity is updated 
		/// Warning: Skips linked entities
		/// </summary>
		/// <returns></returns>
		public Boolean IsUpdated(object entity)
		{
			Boolean isUpdated = false;
			foreach (var pi in entity.GetType().GetRuntimeProperties())
			{
				var originalvalue = OriginalEntity.GetType().GetRuntimeProperty(pi.Name).GetValue(OriginalEntity);
				var currentvalue = pi.GetValue(entity);

				if (originalvalue == null) originalvalue = "null"; 
				if (currentvalue == null) currentvalue = "null";

				if(!originalvalue.Equals(currentvalue))
				{
					isUpdated = true;
				}
			}
			return isUpdated;
		}

		private static object Clone(object entity)
		{
			object returnEntity = Activator.CreateInstance(entity.GetType(), null);
			foreach (var property in entity.GetType().GetRuntimeProperties())
			{
				var value = property.GetValue(entity);
				if (value != null && value.GetType().GetTypeInfo().IsGenericType && value is IEnumerable)
				{
					// Create linked entity
					var newValue = (IList)Activator.CreateInstance(value.GetType());

					foreach (var item in (IEnumerable)value)
					{
						newValue.Add(Clone(item));
					}
					value = newValue;
				}
				returnEntity.GetType().GetRuntimeProperty(property.Name).SetValue(returnEntity, value);
			}
			return returnEntity;
		}

		/// <summary>
		/// Updates the entity
		/// </summary>
		/// <returns>True if the entity is updated</returns>
		public async Task<bool> UpdateAsync(object entity)
		{
			// Convert object to json
			var converter = new EntityConverter();
			string json = await converter.ConvertObjectToJsonAsync(OriginalEntity, entity, _entityControllerDelegate);

			// Update entire object
			Boolean returnValue = false;

			// Update and set _originalentity to current entity (_entity)
			if (await _connection.PutAsync(_keyName, _identifier, json))
			{
				returnValue = true;
				OriginalEntity = Clone(entity);
			}
			return returnValue;
		}

		/// <summary>
		/// Deletes the entity
		/// </summary>
		/// <returns>True if the entity is updated</returns>
		public async Task<bool> DeleteAsync()
		{
			return await _connection.DeleteAsync(_keyName, _identifier);

		}
	}
}
