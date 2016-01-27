using System;
using System.Collections.Generic;
using System.Reflection;
using ExactOnline.Client.Sdk.Controllers;
using ExactOnline.Client.Sdk.Interfaces;

namespace ExactOnline.Client.Sdk.Helpers
{
	using System.Collections.Generic;

	using ExactOnline.Client.Models;

	/// <summary>
	/// Manages instances of controllers
	/// </summary>
	public class ControllerList
	{
		private readonly IApiConnector _connector;
		private readonly string _baseUrl;
		private readonly Dictionary<string, object> _controllers;
		private Dictionary<string, string> _services;

		public ControllerList(IApiConnector connector, string baseUrl)
		{
			_baseUrl = baseUrl;
			_connector = connector;
			_controllers = new Dictionary<string, object>();
			_services = new Services().Services;
		}

		/// <summary>
		/// Gets the name of the generic type
		/// </summary>
		private static string GetTypename<T>()
		{
			// Get entity name from type
			var entity = typeof(T).ToString();
			var split = entity.Split('.');
			entity = split[split.Length - 1];
			return entity;
		}

		/// <summary>
		/// Method for getting the correct EntityManager. This method is used as a Delegate
		/// </summary>
		public IEntityManager GetEntityManager(Type type)
		{
			var method = typeof(ControllerList).GetTypeInfo().GetDeclaredMethod("GetController");
			var genericMethod = method.MakeGenericMethod(new[] { type });
			var controller = (IEntityManager)genericMethod.Invoke(this, null);
			return controller;
		}

		/// <summary>
		/// Returns an instance of Controller with the specified type
		/// </summary>
		public IController<T> GetController<T>() where T : class
		{
			var typename = GetTypename<T>();

			// If not exists: create
			if (!_controllers.ContainsKey(typename))
			{
				ApiConnection conn;

				if (typename == "Me")
				{
					conn = new ApiConnection(_connector, _baseUrl + "system/Me");
				}
				else if (_services.ContainsKey(typename))
				{
					conn = new ApiConnection(_connector, _baseUrl + _services[typename]);
				}
				else
				{
					throw new Exception("Specified entity is not known in Exact Online. Please check the reference documentation");
				}

				var returncontroller = new Controller<T>(conn)
				{
					GetManagerForEntity = GetEntityManager
				};
				_controllers.Add(typename, returncontroller);
			}

			return (Controller<T>)_controllers[typename];
		}

	}
}
