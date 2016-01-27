using ExactOnline.Client.Sdk.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactOnline.Client.Sdk.UnitTests.Tools
{
    public static class JsonHelper
    {
        /// <summary>
        /// Parses an object which is not odata
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static JObject ParseObject(string json)
        {
            return JsonConvert.DeserializeObject<JObject>(json, EntityConverter.GlobalJsonSerializerSettings);
        }

        public static JArray ParseArray(string json)
        {
            return JsonConvert.DeserializeObject<JArray>(json, EntityConverter.GlobalJsonSerializerSettings);
        }
    }
}
