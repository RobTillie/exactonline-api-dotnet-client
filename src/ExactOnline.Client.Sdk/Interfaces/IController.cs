using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExactOnline.Client.Sdk.Interfaces
{
	public interface IController<T>
	{
		Task<List<T>> GetAsync(string query);

        Task<T> GetEntityAsync(string guid, string parameters);

        Task<T> CreateAsync(T entity);

        Task<bool> UpdateAsync(T entity);

        Task<bool> DeleteAsync(T entity);

        Task<int> CountAsync(); // For $count function API

		void RegistrateLinkedEntityField(string fieldname);
	}
}
