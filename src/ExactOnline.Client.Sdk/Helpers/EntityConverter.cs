using System;
using System.Collections.Generic;
using System.Linq;
using ExactOnline.Client.Sdk.Delegates;
using ExactOnline.Client.Sdk.Exceptions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace ExactOnline.Client.Sdk.Helpers
{
	/// <summary>
	/// Convert entities from json to Exact Online object and vice versa
	/// </summary>
	public class EntityConverter
	{
        public static readonly JsonSerializerSettings GlobalJsonSerializerSettings = new JsonSerializerSettings
        {
            DateFormatHandling = DateFormatHandling.MicrosoftDateFormat
        };

        /// <summary>
        /// Convert single object to Dynamic object
        /// </summary>
        public dynamic ConvertJsonToDynamicObject(JObject json)
		{
			try
			{
				return json.ToObject<dynamic>();
			}
			catch(Exception ex)
			{
				throw new IncorrectJsonException(ex.Message);
			}
		}

		/// <summary>
		/// Convert multiple objects to List of Dynamic objects
		/// </summary>
		public List<dynamic> ConvertJsonToDynamicObjectList(JArray json)
		{
            try
            {
                return json.ToObject<List<dynamic>>();
            }
            catch (Exception ex)
            {
                throw new IncorrectJsonException(ex.Message);
            }
        }

		/// <summary>
		/// Converts Dynamic Object to Json String
		/// </summary>
		/// <param name="obj">Dynamic Object to Convert</param>
		/// <returns>Json String</returns>
		public async Task<string> ConvertDynamicObjectToJsonAsync(dynamic obj)
		{
			string json = await JsonHelper.SerializeObjectAsync(obj);
			return json;
		}

		/// <summary>
		/// Converts an Exact Online Object to Json
		/// </summary>
		/// <typeparam name="T">Type of Exact.Web.Api.Models</typeparam>
		/// <param name="entity">entity</param>
		/// <param name="entityControllerDelegate">Delegate for entitycontroller</param>
		/// <returns>Json String</returns>
		public async Task<string> ConvertObjectToJsonAsync<T>(T entity, GetEntityController entityControllerDelegate)
		{
			return await JsonHelper.SerializeObjectAsync(entity, new ExactOnlineJsonConverter());
		}

		/// <summary>
		/// Converts an Object to Json for Updating
		/// The method creates Json using the original entity 
		/// and the current entity to create Json only for altered fields
		/// </summary>
		/// <typeparam name="T">Type of Exact.Web.Api.Models</typeparam>
		/// <param name="originalEntity">Original State of the Entity</param>
		/// <param name="entity">Current State of the Entity</param>
		/// <param name="entityControllerDelegate">Delegate for entitycontroller</param>
		/// <returns>Json String</returns>
		public async Task<string> ConvertObjectToJsonAsync<T>(T originalEntity, T entity, GetEntityController entityControllerDelegate)
		{
			return await JsonHelper.SerializeObjectAsync(entity, new ExactOnlineJsonConverter(originalEntity, entityControllerDelegate));
		}

		/// <summary>
		/// Convert Json to Exact Online Object
		/// </summary>
		/// <typeparam name="T">Type of Exact.Web.Api.Models</typeparam>
		/// <param name="json">Json String</param>
		/// <returns>Exact Online Object</returns>
		public T ConvertJsonToObject<T>(JObject json)
		{
			try
			{
                return json.ToObject<T>();
			}
            catch (Exception ex)
            {
                throw new IncorrectJsonException(ex.Message);
            }
        }

        /// <summary>
        /// Convert Json Array To Object List
        /// </summary>
        /// <typeparam name="T">Specifies the type</typeparam>
        /// <param name="json">Json Array</param>
        /// <returns>List of specified type</returns>
        public List<T> ConvertJsonArrayToObjectList<T>(JArray json)
		{
            if (json == null)
                return null;

			try
			{
				return json.ToObject<List<T>>();
			}
            catch (Exception ex)
            {
                throw new IncorrectJsonException(ex.Message);
            }
        }
    }
}
