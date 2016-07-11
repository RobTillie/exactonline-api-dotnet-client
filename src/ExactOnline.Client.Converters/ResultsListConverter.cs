using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExactOnline.Client.Converters
{
    public class ResultsListConverter<T> : JsonConverter
    {
        public override bool CanWrite
        {
            get
            {
                return false;
            }
        }

        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.StartObject)
            {
                var obj = serializer.Deserialize<JObject>(reader);
                var results = obj["results"];
                return results.ToObject<List<T>>();
            }
            else if (reader.TokenType == JsonToken.StartArray)
            {
                return serializer.Deserialize(reader, objectType);
            }

            return null;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
