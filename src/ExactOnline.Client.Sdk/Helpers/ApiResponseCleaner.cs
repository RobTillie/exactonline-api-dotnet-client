using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ExactOnline.Client.Sdk.Exceptions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

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
		public static async Task<JObject> GetJsonObjectAsync(string response)
		{
            try
            {
                var dict = await JsonHelper.DeserializeObjectAsync<JObject>(response, EntityConverter.GlobalJsonSerializerSettings);
                var d = dict["d"] as JObject;
                CleanObject(d);

                return d ?? dict;
            }
            catch (Exception ex)
            {
                throw new IncorrectJsonException(ex.Message);
            }
		}

		/// <summary>
		/// Fetch Json Array (Json within ['d']['results']) from response
		/// </summary>
        public static async Task<JArray> GetJsonArrayAsync(string response)
        {
            try
            {
                var obj = await JsonHelper.DeserializeObjectAsync(response);

                if (obj is JArray) return (JArray)obj;

                var dict = obj as JObject;
                var innerPart = dict["d"] as JObject;
                if (innerPart != null && innerPart["results"] != null)
                {
                    var jsonArray = (JArray)innerPart["results"];

                    foreach(var ent in jsonArray)
                    {
                        CleanObject(ent);
                    }

                    return jsonArray;
                }
                else if(dict["d"] is JArray)
                {
                    return (JArray)dict["d"];
                }

                throw new IncorrectJsonException("Missing d or results tags");
            }
            catch (Exception e)
            {
                throw new IncorrectJsonException(e.Message);
            }
        }

        private static void CleanObject(JToken token)
        {
            var list = new Dictionary<JToken, JProperty>();

            if (token.GetType() != typeof(JObject))
                return;

            // remove the results nodes
            var childrenWithResults = token.Children<JProperty>()
                .Where(c => c.Children<JObject>()["results"].Count() > 0).ToList();

            foreach(var child in childrenWithResults)
            {
                var resultsProperty = child.Children()["results"];
                var newProperty = new JProperty(child.Name, resultsProperty.Children());
                child.Replace(newProperty);
            }

            // remove __deferred properties
            var deferredChildren = token.Children<JProperty>()
                .Where(c => c.Children<JObject>()["__deferred"].Count() > 0).ToList();

            foreach(var deferred in deferredChildren)
            {
                deferred.Remove();
            }
        }

        #endregion
    }
}
