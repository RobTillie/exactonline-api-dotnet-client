using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactOnline.Client.Sdk.Helpers
{
    /// <summary>
    /// Helper class for async json serialization / deserialization, as these have been deprecated in json.net
    /// </summary>
    public static class JsonHelper
    {
        public static Task<string> SerializeObjectAsync(object value)
        {
            return SerializeObjectAsync(value, Formatting.None, null);
        }

        public static Task<string> SerializeObjectAsync(object value, Formatting formatting)
        {
            return SerializeObjectAsync(value, formatting, null);
        }

        public static Task<string> SerializeObjectAsync(object value, Formatting formatting, JsonSerializerSettings settings)
        {
            return Task.Factory.StartNew(() => JsonConvert.SerializeObject(value, formatting, settings));
        }

        public static Task<T> DeserializeObjectAsync<T>(string value)
        {
            return DeserializeObjectAsync<T>(value, null);
        }

        public static Task<T> DeserializeObjectAsync<T>(string value, JsonSerializerSettings settings)
        {
            return Task.Factory.StartNew(() => JsonConvert.DeserializeObject<T>(value, settings));
        }

        public static Task<object> DeserializeObjectAsync(string value)
        {
            return DeserializeObjectAsync(value, null, null);
        }

        public static Task<object> DeserializeObjectAsync(string value, Type type, JsonSerializerSettings settings)
        {
            return Task.Factory.StartNew(() => JsonConvert.DeserializeObject(value, type, settings));
        }

        public static Task<string> SerializeObjectAsync(object value, params JsonConverter[] converters)
        {
            return Task.Factory.StartNew(() => JsonConvert.SerializeObject(value, converters));
        }
    }
}
