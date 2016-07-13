using System.Threading.Tasks;

namespace ExactOnline.Client.Sdk.Interfaces
{
	public interface IApiConnector
	{
		Task<string> DoGetRequestAsync(string endpoint, string parameters);

        Task<string> DoPostRequestAsync(string endpoint, string postdata);

        Task<string> DoPutRequestAsync(string endpoint, string putData);

        Task<string> DoDeleteRequestAsync(string endpoint);

        Task<string> DoCleanRequestAsync(string uri); // Request without Content-Type for $count function

        Task<int> GetCurrentDivisionAsync(string website);
	}
}
