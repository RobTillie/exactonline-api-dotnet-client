﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using ExactOnline.Client.Sdk.Interfaces;
using ExactOnline.Client.Models;

namespace ExactOnline.Client.Sdk.Helpers
{
	public class ExactOnlineQuery<T>
	{
		private readonly IController<T> _controller;
		private readonly List<string> _and;

		private string _select;
		private string _skip;
		private string _expand;
		private string _top;
		private string _orderby;

		private string _where;

		/// <summary>
		/// Private constructor, can only be called by static For()
		/// </summary>
		public ExactOnlineQuery(IController<T> controller)
		{
			if (controller == null) { throw new ArgumentException("Instance of type Controller cannot be null"); }
			_and = new List<string>();
			_controller = controller;
		}

		/// <summary>
		/// Creates a 'where' clause to the query
		/// </summary>
		public ExactOnlineQuery<T> Where(string filter)
		{
			if (string.IsNullOrEmpty(filter)) throw new ArgumentException("Query 'where' operator cannot be empty");
			_where = "$filter=" + filter;
			return this;
		}

        /// <summary>
        /// Creates an 'and' clause to the query. This method can't be called before a where clause is set.
        /// </summary>
        public ExactOnlineQuery<T> And(string and)
		{
			if (string.IsNullOrEmpty(and)) throw new ArgumentException("Query 'and' operator cannot be empty");
			if (string.IsNullOrEmpty(_where)) throw new ArgumentException("Query 'and' operator cannot be used before 'where' operator is set");

			_and.Add(and);
			return this;
		}

		/// <summary>
		/// Builds query using the _where and _and properties
		/// </summary>
		/// <returns></returns>
		private string CreateODataQuery(bool selectIsMandatory)
		{
			var queryParts = new List<string>();

			if (!string.IsNullOrEmpty(_where))
			{
                var completeWhere = _where;

                foreach (var andPart in _and)
                    completeWhere += " and " + andPart;

				queryParts.Add(completeWhere);
			}

			// Add $filter
			// queryParts.AddRange(_and);


			// Add $select
			if (!string.IsNullOrEmpty(_select))
			{
				queryParts.Add(_select);
			}
			else if (selectIsMandatory)
			{
				throw new Exception("You have to specify which fields you want to select");
			}

			// Add $skip
			if (!string.IsNullOrEmpty(_skip))
			{
				queryParts.Add(_skip);
			}

			// Add $expand
			if (!string.IsNullOrEmpty(_expand))
			{
				queryParts.Add(_expand);
			}

			// Add top
			if (!string.IsNullOrEmpty(_top))
			{
				queryParts.Add(_top);
			}

			// Add orderby
			if (!string.IsNullOrEmpty(_orderby))
			{
				queryParts.Add(_orderby);
			}

			string query = string.Join("&", queryParts);

			return query;
		}

		/// <summary>
		/// Specify the fields to get from the API
		/// </summary>
		/// <param name="field">Name of the field</param>
		/// <returns></returns>
		public ExactOnlineQuery<T> Select(string field)
		{
			return Select(new[] { field });
		}

		/// <summary>
		/// Specify the fields to get from the API
		/// </summary>
		/// <param name="fields">Name of fields</param>
		/// <returns></returns>
		public ExactOnlineQuery<T> Select(string[] fields)
		{
			if (fields.Length > 0)
			{
				string select = fields.Aggregate("$select=", (current, item) => current + (item + ","));
				select = select.Remove(select.Length - 1);
				_select = select;
			}
			return this;
		}

		/// <summary>
		/// Specify the number of records to get from the API
		/// </summary>
		/// <param name="top"></param>
		/// <returns></returns>
		public ExactOnlineQuery<T> Top(int top)
		{
			_top = string.Format("$top={0}", top);
			return this;
		}

		/// <summary>
		/// Paging: Specify the number of records that must be skipped
		/// </summary>
		/// <param name="skip"></param>
		/// <returns></returns>
		public ExactOnlineQuery<T> Skip(int skip)
		{
			_skip = string.Format("$skip={0}", skip);
			return this;
		}

		/// <summary>
		/// Specify the field to order by
		/// </summary>
		/// <param name="orderby"></param>
		/// <returns></returns>
		public ExactOnlineQuery<T> OrderBy(string orderby)
		{
			return OrderBy(new[] { orderby });
		}

		/// <summary>
		/// Specify the fields to order by
		/// </summary>
		/// <param name="orderby"></param>
		/// <returns></returns>
		public ExactOnlineQuery<T> OrderBy(string[] orderby)
		{
			string orderbyclause = @orderby.Aggregate("", (current, item) => current + (item + ","));
			orderbyclause = orderbyclause.Remove(orderbyclause.Length - 1);

			_orderby = string.Format("$orderby={0}", orderbyclause);
			return this;
		}

		/// <summary>
		/// Field to Expand with coupled entities
		/// </summary>
		public ExactOnlineQuery<T> Expand(string expand)
		{
			_controller.RegistrateLinkedEntityField(expand);
			_expand = "$expand=" + expand;
			return this;
		}

		/// <summary>
		/// Count the amount of entities in the the entity
		/// </summary>
		/// <returns></returns>
		public async Task<int> CountAsync()
		{
			return await _controller.CountAsync();
		}


		/// <summary>
		/// Returns a List of entities using the specified query
		/// </summary>
		/// <returns></returns>
		public async Task<List<T>> GetAsync()
		{
			return await _controller.GetAsync(CreateODataQuery(true));
		}

        /// <summary>
        /// Returns a list of all the entities using the specified query
        /// </summary>
        public async Task<List<T>> GetAllAsync()
        {
            const int toTake = 50;
            var round = 0;
            var hasNew = true;
            var received = new List<T>();
            while (hasNew)
            {
                var request = await this.Skip(round * toTake).Top(toTake).GetAsync();
                received.AddRange(request);
                round++;
                hasNew = request.Count == toTake;
            }
            return received;
        }

        public async Task<List<T>> GetAllModifiedAfterAsync(DateTime? modifiedAfter)
        {
            if(modifiedAfter.HasValue)
            {
                var modifiedFilter = $"Modified gt datetime'{modifiedAfter:yyyy-MM-ddTHH:mm:ss}'";

                if (_where == null)
                    Where(modifiedFilter);
                else
                    And(modifiedFilter);

                OrderBy("Modified asc");
            }

            return await GetAllAsync();
        }

        /// <summary>
        /// Returns one instance of an entity using the specified identifier
        /// </summary>
        public async Task<T> GetEntityAsync(string identifier)
		{
			if (string.IsNullOrEmpty(identifier)) throw new ArgumentException("Get entity: Identifier cannot be empty");
			string query = CreateODataQuery(false);
			return await _controller.GetEntityAsync(identifier, query);
		}

		/// <summary>
		/// Returns one instance of an entity using the specified identifier
		/// </summary>
		public async Task<T> GetEntityAsync(Guid identifier)
		{
			if (identifier == Guid.Empty) throw new ArgumentException("Get entity: Identifier cannot be empty");
			string query = CreateODataQuery(false);
			return await _controller.GetEntityAsync(identifier.ToString(), query);
		}

		/// <summary>
		/// Returns one instance of an entity using the specified identifier
		/// </summary>
		public async Task<T> GetEntityAsync(int identifier)
		{
			string query = CreateODataQuery(false);
			return await _controller.GetEntityAsync(identifier.ToString(CultureInfo.InvariantCulture), query);
		}

		/// <summary>
		/// Updates the specified entity
		/// </summary>
		public async Task<bool> UpdateAsync(T entity)
		{
			if (entity == null) throw new ArgumentException("Update entity: Entity cannot be null");
			return await _controller.UpdateAsync(entity);
		}

		/// <summary>
		/// Deletes the specified entity
		/// </summary>
		public async Task<bool> DeleteAsync(T entity)
		{
			if (entity == null) throw new ArgumentException("Delete entity: Entity cannot be null");
			return await _controller.DeleteAsync(entity);
		}

		/// <summary>
		/// Inserts the specified entity into Exact Online
		/// </summary>
		public async Task<T> InsertAsync(T entity)
		{
			if (entity == null) throw new ArgumentException("Insert entity: Entity cannot be null");
			return await _controller.CreateAsync(entity);
		}

        #region Async support



        #endregion
    }
}
