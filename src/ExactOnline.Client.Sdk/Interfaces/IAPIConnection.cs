using System;
using System.Threading.Tasks;

namespace ExactOnline.Client.Sdk.Interfaces
{
	public interface IApiConnection
	{
		Task<string> GetAsync(string parameters);

        Task<string> GetEntityAsync(string keyname, string guid, string parameters);

        Task<string> PostAsync(string data);

        Task<bool> PutAsync(string keyName, string guid, string data);

        Task<bool> DeleteAsync(string keyName, string guid);

		Task<int> CountAsync();

	}
}
