using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExactOnline.Client.Sdk.Helpers
{
    public static class ReflectionHelper
    {
        private static string[] ProhibitedProperties = new[] { "LocalId", "RemoteId" };
        public static string[] GetAllProperties<T>()
        {            
            return typeof(T).GetRuntimeProperties().Where(prop => !ProhibitedProperties.Any(x => x == prop.Name)).Select(p => p.Name).ToArray();
        }
    }
}
