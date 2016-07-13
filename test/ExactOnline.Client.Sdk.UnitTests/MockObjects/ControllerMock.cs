using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ExactOnline.Client.Sdk.Interfaces;

namespace ExactOnline.Client.Sdk.UnitTests.MockObjects
{
	public sealed class ControllerMock<T> : IController<T>
	{

		public async Task<int> CountAsync()
		{
			return 0;
		}

		public string ODataQuery { get; set; }

        async Task<List<T>> IController<T>.GetAsync(string query)
		{
			ODataQuery = query;
			return null;
		}

        async Task<T> IController<T>.GetEntityAsync(string guid, string parameters)
		{

			throw new NotImplementedException();
		}

        async Task<T> IController<T>.CreateAsync(T entity)
		{
			return entity;
		}

        async Task<bool> IController<T>.UpdateAsync(T entity)
		{
			return true;
		}

        async Task<bool> IController<T>.DeleteAsync(T entity)
		{
			return true;
		}

		#region IController<T> Members


		public bool IsManagedEntity(T entity)
		{
			return true;
		}

		#endregion

		#region IController<T> Members


		public Task<List<T>> GetAsync(string query)
		{
			throw new NotImplementedException();
		}

		#endregion

		#region IController<T> Members


		public T GetEntity(string guid, string parameters)
		{
			throw new NotImplementedException();
		}

		public void RegistrateLinkedEntityField(string fieldname)
		{
		}

		#endregion
	}
}
