using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ExactOnline.Client.Sdk.Exceptions;
using Newtonsoft.Json;

namespace ExactOnline.Client.Sdk.Helpers
{
	/// <summary>
	/// Class for stripping unnecessary Json tags from API Response
	/// </summary>
	public class ApiResponseCleaner
	{
		#region Public methods

		/// <summary>
		/// Fetch Json Object (Json within ['d'] name/value pair) from response
		/// </summary>
		/// <param name="response"></param>
		/// <returns></returns>
		public static string GetJsonObject(string response)
		{
            var dict = JsonConvert.DeserializeObject<Dictionary<string,object>>(response);
            var d = (Dictionary<string, object>)dict["d"];
            return GetJsonFromDictionary(d);
		}

		/// <summary>
		/// Fetch Json Array (Json within ['d']['results']) from response
		/// </summary>
		public static string GetJsonArray(string response)
		{
			try
			{
				IList results;
				var dict = JsonConvert.DeserializeObject<Dictionary<string, object>>(response);
                var innerPart = dict["d"];
				if (innerPart.GetType() == typeof(Dictionary<string, object>))
				{
					var d = (Dictionary<string, object>)dict["d"];
					results = (IList)d["results"];
				}
				else
				{
					results = (IList)innerPart;
				}
				return GetJsonFromResultDictionary(results);
			}
			catch (Exception e)
			{
				throw new IncorrectJsonException(e.Message);
			}

		}

		#endregion

		#region Private methods

		/// <summary>
		/// Converts key/value pairs to json
		/// </summary>
		private static string GetJsonFromDictionary(Dictionary<string, object> dictionary)
		{
			string json = "{";

			foreach (var entry in dictionary)
			{
				if (entry.Value == null || entry.Value.GetType() != typeof(Dictionary<string, object>))
				{
					// Entry is of type keyvaluepair
					json += "\"" + entry.Key + "\":";
					if (entry.Value == null)
					{
						json += "null";
					}
					else
					{
						json += JsonConvert.ToString(entry.Value.ToString());
					}
					json += ",";
				}
				else
				{
					// Create linked entities json
					var subcollection = (Dictionary<string, object>)entry.Value;
					if (subcollection.Keys.Contains("results"))
					{
						var results = (IList)subcollection["results"];
						string subjson = GetJsonFromResultDictionary(results);
						if (subjson.Length > 0)
						{
							json += "\"" + entry.Key + "\":";
							json += subjson;
							json += ",";
						}
					}
				}
			}

			json = json.Remove(json.Length - 1, 1); // Remove last comma
			json += "}";

			return json;
		}

		private static string GetJsonFromResultDictionary(IList results)
		{
			string json = "[";
			if (results != null && results.Count > 0)
			{
				foreach (Dictionary<string, object> entity in results)
				{
					json += GetJsonFromDictionary(entity) + ",";
				}

				json = json.Remove(json.Length - 1, 1); // Remove last comma
			}
			json += "]";
			return json;
		}

		#endregion

	}
}
