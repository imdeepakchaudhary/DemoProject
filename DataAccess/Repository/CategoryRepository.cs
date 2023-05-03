/***************************************************************/
/* Code Writer (written by Anish M Mathew )                                 */
/*                                                                          */
/* This file was automatically generated using Code Writer                  */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated : 4/30/2023 2:33:55 PM                                      */
/*                                                                          */
/* More Details    --                                                       */
/*http://visualstudiogallery.msdn.microsoft.com/40d92d45-107e-4f83-b6c5-50a7e2419389*/
/****************************************************************************/
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using Dapper;
using System.Threading.Tasks;
using DataAccess.Infrastructure;
using DataAccess.Entities;

namespace DataAccess.Repository
{
	public partial class CategoryRepository : BaseRepository, ICategoryRepository
	{
		public CategoryRepository(IConnectionFactory connectionFactory) : base(connectionFactory) { }
		
		#region Select One
		/// <summary>
		/// Get data according to the primary key value.
		/// </summary>
		/// <param name="id">System.Int32?</param>
		public async Task<Category> Get(System.Int32? id)
		{
			using (var connection = connectionFactory.GetConnection)
			{
				var query = "[dbo].Category_SELECT";
				var param = new DynamicParameters();
				param.Add(@"id", id, DbType.Int32);
				var list = await SqlMapper.QueryAsync<Category>(connection, query, param, commandType: CommandType.StoredProcedure);
				return list.FirstOrDefault();
				
			}
		}
		#endregion
		
		#region Search
		public async Task<IEnumerable<Category>> Search(int pageIndex, int pageSize)
		{
			
			using (var connection = connectionFactory.GetConnection)
			{
				var query = "[dbo].Category_PAGING";
				var param = new DynamicParameters();
				param.Add("@PageIndex", pageIndex);
				param.Add("@PageSize", pageSize);
				
				var list = await SqlMapper.QueryAsync<Category>(connection, query, param, commandType: CommandType.StoredProcedure);
				
				if (list == null)
				return null;
				else
				return list;
				
			}
		}
		public async Task<IEnumerable<Category>> Search(int pageIndex, int pageSize,string sortBy, string orderBy)
		{
			
			using (var connection = connectionFactory.GetConnection)
			{
				var query = "[dbo].Category_SORT";
				var param = new DynamicParameters();
				param.Add("@PageIndex", pageIndex);
				param.Add("@PageSize", pageSize);
				param.Add("@sortBy", sortBy);
				param.Add("@orderBy", orderBy);
				
				var list = await SqlMapper.QueryAsync<Category>(connection, query, param, commandType: CommandType.StoredProcedure);
				
				if (list == null)
				return null;
				else
				return list;
				
			}
		}
		public async Task<IEnumerable<Category>> Search(int pageIndex, int pageSize,string sortBy, string orderBy, string searchstring)
		{
			
			using (var connection = connectionFactory.GetConnection)
			{
				var query = "[dbo].Category_CUSTOM";
				var param = new DynamicParameters();
				param.Add("@PageIndex", pageIndex);
				param.Add("@PageSize", pageSize);
				param.Add("@sortBy", sortBy);
				param.Add("@orderBy", orderBy);
				param.Add("@searchstring", searchstring);
				
				var list = await SqlMapper.QueryAsync<Category>(connection, query, param, commandType: CommandType.StoredProcedure);
				
				if (list == null)
				return null;
				else
				return list;
				
			}
		}
		public async Task<IEnumerable<Category>> Search(System.Int32? id, System.String name, System.String description, System.String status, System.DateTime? ceatedOn, System.String ceatedBy, System.DateTime? updatedOn, System.String updatedBy)
		{
			try
			{
				
				using (var connection = connectionFactory.GetConnection)
				{
					var query = "[dbo].Category_SEARCH";
					var param = new DynamicParameters();
					param.Add("id",id, DbType.Int32);
					param.Add("name",name, DbType.String);
					param.Add("description",description, DbType.String);
					param.Add("status",status, DbType.String);
					param.Add("ceatedOn",ceatedOn, DbType.DateTime);
					param.Add("ceatedBy",ceatedBy, DbType.String);
					param.Add("updatedOn",updatedOn, DbType.DateTime);
					param.Add("updatedBy",updatedBy, DbType.String);
					
					var list = await SqlMapper.QueryAsync<Category>(connection, query, param, commandType: CommandType.StoredProcedure);
					
					if (list == null)
					return null;
					else
					return list;
					
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		#endregion
		
		#region INSERT
		/// <summary>
		/// Insert current Category to database.
		/// </summary>
		/// <param name="name">System.String</param>
		/// <param name="description">System.String</param>
		/// <param name="status">System.String</param>
		/// <param name="ceatedOn">System.DateTime?</param>
		/// <param name="ceatedBy">System.String</param>
		/// <param name="updatedOn">System.DateTime?</param>
		/// <param name="updatedBy">System.String</param>
		public async Task<System.Int32> Insert(System.String name, System.String description, System.String status, System.DateTime? ceatedOn, System.String ceatedBy, System.DateTime? updatedOn, System.String updatedBy)
		{
			try
			{
				
				using (var connection = connectionFactory.GetConnection)
				{
					var query = "[dbo].Category_INSERT";
					var param = new DynamicParameters();
					param.Add("name", name, DbType.String);
					param.Add("description", description, DbType.String);
					param.Add("status", status, DbType.String);
					param.Add("ceatedOn", ceatedOn, DbType.DateTime);
					param.Add("ceatedBy", ceatedBy, DbType.String);
					param.Add("updatedOn", updatedOn, DbType.DateTime);
					param.Add("updatedBy", updatedBy, DbType.String);
					var objs = await SqlMapper.ExecuteScalarAsync<System.Int32>(connection, query, param, commandType: CommandType.StoredProcedure);
					return objs;
					
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		/// <summary>
		/// Insert current Category to database.
		/// </summary>
		/// <param name=Category Objects>Category</param>
		public async Task<System.Int32> Insert(Category model)
		{
			try
			{
				
				using (var connection = connectionFactory.GetConnection)
				{
					var query = "[dbo].Category_INSERT";
					var param = new DynamicParameters();
					param.Add("name", model.Name, DbType.String);
					param.Add("description", model.Description, DbType.String);
					param.Add("status", model.Status, DbType.String);
					param.Add("ceatedOn", model.CeatedOn, DbType.DateTime);
					param.Add("ceatedBy", model.CeatedBy, DbType.String);
					param.Add("updatedOn", model.UpdatedOn, DbType.DateTime);
					param.Add("updatedBy", model.UpdatedBy, DbType.String);
					var objs = await SqlMapper.ExecuteScalarAsync<System.Int32>(connection, query, param, commandType: CommandType.StoredProcedure);
					return objs;
					
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		#endregion
		
		#region UPDATE
		/// <summary>
		/// Update current Category to database.
		/// </summary>
		/// <param name="id">System.Int32?</param>
		/// <param name="name">System.String</param>
		/// <param name="description">System.String</param>
		/// <param name="status">System.String</param>
		/// <param name="ceatedOn">System.DateTime?</param>
		/// <param name="ceatedBy">System.String</param>
		/// <param name="updatedOn">System.DateTime?</param>
		/// <param name="updatedBy">System.String</param>
		public async Task<int> Update(System.Int32? id, System.String name, System.String description, System.String status, System.DateTime? ceatedOn, System.String ceatedBy, System.DateTime? updatedOn, System.String updatedBy)
		{
			try
			{
				
				using (var connection = connectionFactory.GetConnection)
				{
					var query = "[dbo].Category_UPDATE";
					var param = new DynamicParameters();
					param.Add("id", id, DbType.Int32);
					param.Add("name", name, DbType.String);
					param.Add("description", description, DbType.String);
					param.Add("status", status, DbType.String);
					param.Add("ceatedOn", ceatedOn, DbType.DateTime);
					param.Add("ceatedBy", ceatedBy, DbType.String);
					param.Add("updatedOn", updatedOn, DbType.DateTime);
					param.Add("updatedBy", updatedBy, DbType.String);
					var objs = await SqlMapper.ExecuteAsync(connection, query, param, commandType: CommandType.StoredProcedure);
					
					return objs;
					
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public async Task<int> Update(Category model)
		{
			try
			{
				
				using (var connection = connectionFactory.GetConnection)
				{
					var query = "[dbo].Category_UPDATE";
					var param = new DynamicParameters();
					param.Add("id", model.Id, DbType.Int32);
					param.Add("name", model.Name, DbType.String);
					param.Add("description", model.Description, DbType.String);
					param.Add("status", model.Status, DbType.String);
					param.Add("ceatedOn", model.CeatedOn, DbType.DateTime);
					param.Add("ceatedBy", model.CeatedBy, DbType.String);
					param.Add("updatedOn", model.UpdatedOn, DbType.DateTime);
					param.Add("updatedBy", model.UpdatedBy, DbType.String);
					var objs = await SqlMapper.ExecuteAsync(connection, query, param, commandType: CommandType.StoredProcedure);
					return objs;
					
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		#endregion
		
		#region DELETE
		/// <summary>
		/// Delete current Category from database.
		/// </summary>
		/// <param name="id">System.Int32?</param>
		public async Task<int> Delete(System.Int32? id)
		{
			using (var connection = connectionFactory.GetConnection)
			{
				var query = "[dbo].Category_DELETE";
				var param = new DynamicParameters();
				param.Add("id", id, DbType.Int32);
				var iValue = await SqlMapper.ExecuteAsync(connection, query, param, commandType: CommandType.StoredProcedure);
				return iValue;
				
			}
		}
		#endregion
		
		
	}
}

