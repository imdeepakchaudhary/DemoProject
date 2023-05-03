/***************************************************************/
/* Code Writer (written by Anish M Mathew )                                 */
/*                                                                          */
/* This file was automatically generated using Code Writer                  */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated : 06/12/2018 18:39:23                                      */
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
	public partial class AspNetUsersRepository : BaseRepository, IAspNetUsersRepository
	{
		public AspNetUsersRepository(IConnectionFactory connectionFactory) : base(connectionFactory) { }
		
		#region Select One
		/// <summary>
		/// Get data according to the primary key value.
		/// </summary>
		/// <param name="id">System.String</param>
		public async Task<AspNetUsers> Get(System.String id)
		{
			using (var connection = connectionFactory.GetConnection)
			{
				var query = "[dbo].AspNetUsers_SELECT";
				var param = new DynamicParameters();
				param.Add(@"id", id, DbType.String);
				var list = await SqlMapper.QueryAsync<AspNetUsers>(connection, query, param, commandType: CommandType.StoredProcedure);
				return list.FirstOrDefault();
				
			}
		}
		#endregion
		
		#region Select One
		/// <summary>
		/// Get data according to the primary key value.
		/// </summary>
		/// <param name="id">System.String</param>
		public async Task<AspNetUsers> Get(System.String id,int CID)
		{
			using (var connection = connectionFactory.GetConnection)
			{
				var query = "[dbo].AspNetUsers_SELECT_COMPANY";
				var param = new DynamicParameters();
				param.Add(@"id", id, DbType.String);
				param.Add("@CID", CID);
				var list = await SqlMapper.QueryAsync<AspNetUsers>(connection, query, param, commandType: CommandType.StoredProcedure);
				return list.FirstOrDefault();
				
			}
		}
		#endregion
		
		#region Search
		public async Task<IEnumerable<AspNetUsers>> Search(int pageIndex, int pageSize)
		{
			
			using (var connection = connectionFactory.GetConnection)
			{
				var query = "[dbo].AspNetUsers_PAGING";
				var param = new DynamicParameters();
				param.Add("@PageIndex", pageIndex);
				param.Add("@PageSize", pageSize);
				
				var list = await SqlMapper.QueryAsync<AspNetUsers>(connection, query, param, commandType: CommandType.StoredProcedure);
				
				if (list == null)
				return null;
				else
				return list;
				
			}
		}
		public async Task<IEnumerable<AspNetUsers>> Search(int pageIndex, int pageSize,string sortBy, string orderBy)
		{
			
			using (var connection = connectionFactory.GetConnection)
			{
				var query = "[dbo].AspNetUsers_SORT";
				var param = new DynamicParameters();
				param.Add("@PageIndex", pageIndex);
				param.Add("@PageSize", pageSize);
				param.Add("@sortBy", sortBy);
				param.Add("@orderBy", orderBy);
				
				var list = await SqlMapper.QueryAsync<AspNetUsers>(connection, query, param, commandType: CommandType.StoredProcedure);
				
				if (list == null)
				return null;
				else
				return list;
				
			}
		}
		public async Task<IEnumerable<AspNetUsers>> Search(int pageIndex, int pageSize,int CID)
		{
			
			using (var connection = connectionFactory.GetConnection)
			{
				var query = "[dbo].AspNetUsers_PAGING_COMPANY";
				var param = new DynamicParameters();
				param.Add("@PageIndex", pageIndex);
				param.Add("@PageSize", pageSize);
				param.Add("@CID", CID);
				
				var list = await SqlMapper.QueryAsync<AspNetUsers>(connection, query, param, commandType: CommandType.StoredProcedure);
				
				if (list == null)
				return null;
				else
				return list;
				
			}
		}
		public async Task<IEnumerable<AspNetUsers>> Search(int pageIndex, int pageSize,string sortBy, string orderBy,int CID)
		{
			
			using (var connection = connectionFactory.GetConnection)
			{
				var query = "[dbo].AspNetUsers_SORT_COMPANY";
				var param = new DynamicParameters();
				param.Add("@PageIndex", pageIndex);
				param.Add("@PageSize", pageSize);
				param.Add("@sortBy", sortBy);
				param.Add("@orderBy", orderBy);
				param.Add("@CID", CID);
				
				var list = await SqlMapper.QueryAsync<AspNetUsers>(connection, query, param, commandType: CommandType.StoredProcedure);
				
				if (list == null)
				return null;
				else
				return list;
				
			}
		}
		public async Task<IEnumerable<AspNetUsers>> Search(System.String id, System.Int32? accessFailedCount, System.String concurrencyStamp, System.String email, System.Boolean? emailConfirmed, System.Boolean? lockoutEnabled, System.DateTimeOffset lockoutEnd, System.String normalizedEmail, System.String normalizedUserName, System.String passwordHash, System.String phoneNumber, System.Boolean? phoneNumberConfirmed, System.String securityStamp, System.Boolean? twoFactorEnabled, System.String userName, System.String address, System.Int32? cid, System.String city, System.String country, System.DateTime? dob, System.String firstName, System.Boolean? isActive, System.DateTime? joinTime, System.String lastName, System.String pinCode, System.Int64? restaurantID, System.String state, System.String userImage, System.Boolean? isDeleted, System.String gender, System.Boolean? buzzStatus, System.String notificationToken, System.String device, System.String allergicTo, System.String favouriteDishes, System.String fBid, System.String prefernce, System.String staffCode)
		{
			try
			{
				
				using (var connection = connectionFactory.GetConnection)
				{
					var query = "[dbo].AspNetUsers_SEARCH";
					var param = new DynamicParameters();
					param.Add("id",id, DbType.String);
					param.Add("accessFailedCount",accessFailedCount, DbType.Int32);
					param.Add("concurrencyStamp",concurrencyStamp, DbType.String);
					param.Add("email",email, DbType.String);
					param.Add("emailConfirmed",emailConfirmed, DbType.Boolean);
					param.Add("lockoutEnabled",lockoutEnabled, DbType.Boolean);
					param.Add("lockoutEnd",lockoutEnd, DbType.DateTimeOffset);
					param.Add("normalizedEmail",normalizedEmail, DbType.String);
					param.Add("normalizedUserName",normalizedUserName, DbType.String);
					param.Add("passwordHash",passwordHash, DbType.String);
					param.Add("phoneNumber",phoneNumber, DbType.String);
					param.Add("phoneNumberConfirmed",phoneNumberConfirmed, DbType.Boolean);
					param.Add("securityStamp",securityStamp, DbType.String);
					param.Add("twoFactorEnabled",twoFactorEnabled, DbType.Boolean);
					param.Add("userName",userName, DbType.String);
					param.Add("address",address, DbType.String);
					param.Add("cid",cid, DbType.Int32);
					param.Add("city",city, DbType.String);
					param.Add("country",country, DbType.String);
					param.Add("dob",dob, DbType.DateTime2);
					param.Add("firstName",firstName, DbType.String);
					param.Add("isActive",isActive, DbType.Boolean);
					param.Add("joinTime",joinTime, DbType.DateTime2);
					param.Add("lastName",lastName, DbType.String);
					param.Add("pinCode",pinCode, DbType.String);
					param.Add("restaurantID",restaurantID, DbType.Int64);
					param.Add("state",state, DbType.String);
					param.Add("userImage",userImage, DbType.String);
					param.Add("isDeleted",isDeleted, DbType.Boolean);
					param.Add("gender",gender, DbType.String);
					param.Add("buzzStatus",buzzStatus, DbType.Boolean);
					param.Add("notificationToken",notificationToken, DbType.String);
					param.Add("device",device, DbType.String);
					param.Add("allergicTo",allergicTo, DbType.String);
					param.Add("favouriteDishes",favouriteDishes, DbType.String);
					param.Add("fBid",fBid, DbType.String);
					param.Add("prefernce",prefernce, DbType.String);
					param.Add("staffCode",staffCode, DbType.String);
					
					var list = await SqlMapper.QueryAsync<AspNetUsers>(connection, query, param, commandType: CommandType.StoredProcedure);
					
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
		/// Insert current AspNetUsers to database.
		/// </summary>
		/// <param name="id">System.String</param>
		/// <param name="accessFailedCount">System.Int32?</param>
		/// <param name="concurrencyStamp">System.String</param>
		/// <param name="email">System.String</param>
		/// <param name="emailConfirmed">System.Boolean?</param>
		/// <param name="lockoutEnabled">System.Boolean?</param>
		/// <param name="lockoutEnd">System.DateTimeOffset</param>
		/// <param name="normalizedEmail">System.String</param>
		/// <param name="normalizedUserName">System.String</param>
		/// <param name="passwordHash">System.String</param>
		/// <param name="phoneNumber">System.String</param>
		/// <param name="phoneNumberConfirmed">System.Boolean?</param>
		/// <param name="securityStamp">System.String</param>
		/// <param name="twoFactorEnabled">System.Boolean?</param>
		/// <param name="userName">System.String</param>
		/// <param name="address">System.String</param>
		/// <param name="cid">System.Int32?</param>
		/// <param name="city">System.String</param>
		/// <param name="country">System.String</param>
		/// <param name="dob">System.DateTime?</param>
		/// <param name="firstName">System.String</param>
		/// <param name="isActive">System.Boolean?</param>
		/// <param name="joinTime">System.DateTime?</param>
		/// <param name="lastName">System.String</param>
		/// <param name="pinCode">System.String</param>
		/// <param name="restaurantID">System.Int64?</param>
		/// <param name="state">System.String</param>
		/// <param name="userImage">System.String</param>
		/// <param name="isDeleted">System.Boolean?</param>
		/// <param name="gender">System.String</param>
		/// <param name="buzzStatus">System.Boolean?</param>
		/// <param name="notificationToken">System.String</param>
		/// <param name="device">System.String</param>
		/// <param name="allergicTo">System.String</param>
		/// <param name="favouriteDishes">System.String</param>
		/// <param name="fBid">System.String</param>
		/// <param name="prefernce">System.String</param>
		/// <param name="staffCode">System.String</param>
		public async Task<int> Insert(System.String id, System.Int32? accessFailedCount, System.String concurrencyStamp, System.String email, System.Boolean? emailConfirmed, System.Boolean? lockoutEnabled, System.DateTimeOffset lockoutEnd, System.String normalizedEmail, System.String normalizedUserName, System.String passwordHash, System.String phoneNumber, System.Boolean? phoneNumberConfirmed, System.String securityStamp, System.Boolean? twoFactorEnabled, System.String userName, System.String address, System.Int32? cid, System.String city, System.String country, System.DateTime? dob, System.String firstName, System.Boolean? isActive, System.DateTime? joinTime, System.String lastName, System.String pinCode, System.Int64? restaurantID, System.String state, System.String userImage, System.Boolean? isDeleted, System.String gender, System.Boolean? buzzStatus, System.String notificationToken, System.String device, System.String allergicTo, System.String favouriteDishes, System.String fBid, System.String prefernce, System.String staffCode)
		{
			try
			{
				
				using (var connection = connectionFactory.GetConnection)
				{
					var query = "[dbo].AspNetUsers_INSERT";
					var param = new DynamicParameters();
					param.Add("id", id, DbType.String);
					param.Add("accessFailedCount", accessFailedCount, DbType.Int32);
					param.Add("concurrencyStamp", concurrencyStamp, DbType.String);
					param.Add("email", email, DbType.String);
					param.Add("emailConfirmed", emailConfirmed, DbType.Boolean);
					param.Add("lockoutEnabled", lockoutEnabled, DbType.Boolean);
					param.Add("lockoutEnd", lockoutEnd, DbType.DateTimeOffset);
					param.Add("normalizedEmail", normalizedEmail, DbType.String);
					param.Add("normalizedUserName", normalizedUserName, DbType.String);
					param.Add("passwordHash", passwordHash, DbType.String);
					param.Add("phoneNumber", phoneNumber, DbType.String);
					param.Add("phoneNumberConfirmed", phoneNumberConfirmed, DbType.Boolean);
					param.Add("securityStamp", securityStamp, DbType.String);
					param.Add("twoFactorEnabled", twoFactorEnabled, DbType.Boolean);
					param.Add("userName", userName, DbType.String);
					param.Add("address", address, DbType.String);
					param.Add("cid", cid, DbType.Int32);
					param.Add("city", city, DbType.String);
					param.Add("country", country, DbType.String);
					param.Add("dob", dob, DbType.DateTime2);
					param.Add("firstName", firstName, DbType.String);
					param.Add("isActive", isActive, DbType.Boolean);
					param.Add("joinTime", joinTime, DbType.DateTime2);
					param.Add("lastName", lastName, DbType.String);
					param.Add("pinCode", pinCode, DbType.String);
					param.Add("restaurantID", restaurantID, DbType.Int64);
					param.Add("state", state, DbType.String);
					param.Add("userImage", userImage, DbType.String);
					param.Add("isDeleted", isDeleted, DbType.Boolean);
					param.Add("gender", gender, DbType.String);
					param.Add("buzzStatus", buzzStatus, DbType.Boolean);
					param.Add("notificationToken", notificationToken, DbType.String);
					param.Add("device", device, DbType.String);
					param.Add("allergicTo", allergicTo, DbType.String);
					param.Add("favouriteDishes", favouriteDishes, DbType.String);
					param.Add("fBid", fBid, DbType.String);
					param.Add("prefernce", prefernce, DbType.String);
					param.Add("staffCode", staffCode, DbType.String);
					var objs = await SqlMapper.ExecuteAsync(connection, query, param, commandType: CommandType.StoredProcedure);
					return objs;
					
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		/// <summary>
		/// Insert current AspNetUsers to database.
		/// </summary>
		/// <param name=AspNetUsers Objects>AspNetUsers</param>
		public async Task<int> Insert(AspNetUsers model)
		{
			try
			{
				
				using (var connection = connectionFactory.GetConnection)
				{
					var query = "[dbo].AspNetUsers_INSERT";
					var param = new DynamicParameters();
					param.Add("id", model.Id, DbType.String);
					param.Add("accessFailedCount", model.AccessFailedCount, DbType.Int32);
					param.Add("concurrencyStamp", model.ConcurrencyStamp, DbType.String);
					param.Add("email", model.Email, DbType.String);
					param.Add("emailConfirmed", model.EmailConfirmed, DbType.Boolean);
					param.Add("lockoutEnabled", model.LockoutEnabled, DbType.Boolean);
					param.Add("lockoutEnd", model.LockoutEnd, DbType.DateTimeOffset);
					param.Add("normalizedEmail", model.NormalizedEmail, DbType.String);
					param.Add("normalizedUserName", model.NormalizedUserName, DbType.String);
					param.Add("passwordHash", model.PasswordHash, DbType.String);
					param.Add("phoneNumber", model.PhoneNumber, DbType.String);
					param.Add("phoneNumberConfirmed", model.PhoneNumberConfirmed, DbType.Boolean);
					param.Add("securityStamp", model.SecurityStamp, DbType.String);
					param.Add("twoFactorEnabled", model.TwoFactorEnabled, DbType.Boolean);
					param.Add("userName", model.UserName, DbType.String);
					param.Add("address", model.Address, DbType.String);
					param.Add("cid", model.Cid, DbType.Int32);
					param.Add("city", model.City, DbType.String);
					param.Add("country", model.Country, DbType.String);
					param.Add("dob", model.Dob, DbType.DateTime2);
					param.Add("firstName", model.FirstName, DbType.String);
					param.Add("isActive", model.IsActive, DbType.Boolean);
					param.Add("joinTime", model.JoinTime, DbType.DateTime2);
					param.Add("lastName", model.LastName, DbType.String);
					param.Add("pinCode", model.PinCode, DbType.String);
					param.Add("restaurantID", model.RestaurantID, DbType.Int64);
					param.Add("state", model.State, DbType.String);
					param.Add("userImage", model.UserImage, DbType.String);
					param.Add("isDeleted", model.IsDeleted, DbType.Boolean);
					param.Add("gender", model.Gender, DbType.String);
					param.Add("buzzStatus", model.BuzzStatus, DbType.Boolean);
					param.Add("notificationToken", model.NotificationToken, DbType.String);
					param.Add("device", model.Device, DbType.String);
					param.Add("allergicTo", model.AllergicTo, DbType.String);
					param.Add("favouriteDishes", model.FavouriteDishes, DbType.String);
					param.Add("fBid", model.FBid, DbType.String);
					param.Add("prefernce", model.Prefernce, DbType.String);
					param.Add("staffCode", model.StaffCode, DbType.String);
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
		
		#region UPDATE
		/// <summary>
		/// Update current AspNetUsers to database.
		/// </summary>
		/// <param name="id">System.String</param>
		/// <param name="accessFailedCount">System.Int32?</param>
		/// <param name="concurrencyStamp">System.String</param>
		/// <param name="email">System.String</param>
		/// <param name="emailConfirmed">System.Boolean?</param>
		/// <param name="lockoutEnabled">System.Boolean?</param>
		/// <param name="lockoutEnd">System.DateTimeOffset</param>
		/// <param name="normalizedEmail">System.String</param>
		/// <param name="normalizedUserName">System.String</param>
		/// <param name="passwordHash">System.String</param>
		/// <param name="phoneNumber">System.String</param>
		/// <param name="phoneNumberConfirmed">System.Boolean?</param>
		/// <param name="securityStamp">System.String</param>
		/// <param name="twoFactorEnabled">System.Boolean?</param>
		/// <param name="userName">System.String</param>
		/// <param name="address">System.String</param>
		/// <param name="cid">System.Int32?</param>
		/// <param name="city">System.String</param>
		/// <param name="country">System.String</param>
		/// <param name="dob">System.DateTime?</param>
		/// <param name="firstName">System.String</param>
		/// <param name="isActive">System.Boolean?</param>
		/// <param name="joinTime">System.DateTime?</param>
		/// <param name="lastName">System.String</param>
		/// <param name="pinCode">System.String</param>
		/// <param name="restaurantID">System.Int64?</param>
		/// <param name="state">System.String</param>
		/// <param name="userImage">System.String</param>
		/// <param name="isDeleted">System.Boolean?</param>
		/// <param name="gender">System.String</param>
		/// <param name="buzzStatus">System.Boolean?</param>
		/// <param name="notificationToken">System.String</param>
		/// <param name="device">System.String</param>
		/// <param name="allergicTo">System.String</param>
		/// <param name="favouriteDishes">System.String</param>
		/// <param name="fBid">System.String</param>
		/// <param name="prefernce">System.String</param>
		/// <param name="staffCode">System.String</param>
		public async Task<int> Update(System.String id, System.Int32? accessFailedCount, System.String concurrencyStamp, System.String email, System.Boolean? emailConfirmed, System.Boolean? lockoutEnabled, System.DateTimeOffset lockoutEnd, System.String normalizedEmail, System.String normalizedUserName, System.String passwordHash, System.String phoneNumber, System.Boolean? phoneNumberConfirmed, System.String securityStamp, System.Boolean? twoFactorEnabled, System.String userName, System.String address, System.Int32? cid, System.String city, System.String country, System.DateTime? dob, System.String firstName, System.Boolean? isActive, System.DateTime? joinTime, System.String lastName, System.String pinCode, System.Int64? restaurantID, System.String state, System.String userImage, System.Boolean? isDeleted, System.String gender, System.Boolean? buzzStatus, System.String notificationToken, System.String device, System.String allergicTo, System.String favouriteDishes, System.String fBid, System.String prefernce, System.String staffCode)
		{
			try
			{
				
				using (var connection = connectionFactory.GetConnection)
				{
					var query = "[dbo].AspNetUsers_UPDATE";
					var param = new DynamicParameters();
					param.Add("id", id, DbType.String);
					param.Add("accessFailedCount", accessFailedCount, DbType.Int32);
					param.Add("concurrencyStamp", concurrencyStamp, DbType.String);
					param.Add("email", email, DbType.String);
					param.Add("emailConfirmed", emailConfirmed, DbType.Boolean);
					param.Add("lockoutEnabled", lockoutEnabled, DbType.Boolean);
					param.Add("lockoutEnd", lockoutEnd, DbType.DateTimeOffset);
					param.Add("normalizedEmail", normalizedEmail, DbType.String);
					param.Add("normalizedUserName", normalizedUserName, DbType.String);
					param.Add("passwordHash", passwordHash, DbType.String);
					param.Add("phoneNumber", phoneNumber, DbType.String);
					param.Add("phoneNumberConfirmed", phoneNumberConfirmed, DbType.Boolean);
					param.Add("securityStamp", securityStamp, DbType.String);
					param.Add("twoFactorEnabled", twoFactorEnabled, DbType.Boolean);
					param.Add("userName", userName, DbType.String);
					param.Add("address", address, DbType.String);
					param.Add("cid", cid, DbType.Int32);
					param.Add("city", city, DbType.String);
					param.Add("country", country, DbType.String);
					param.Add("dob", dob, DbType.DateTime2);
					param.Add("firstName", firstName, DbType.String);
					param.Add("isActive", isActive, DbType.Boolean);
					param.Add("joinTime", joinTime, DbType.DateTime2);
					param.Add("lastName", lastName, DbType.String);
					param.Add("pinCode", pinCode, DbType.String);
					param.Add("restaurantID", restaurantID, DbType.Int64);
					param.Add("state", state, DbType.String);
					param.Add("userImage", userImage, DbType.String);
					param.Add("isDeleted", isDeleted, DbType.Boolean);
					param.Add("gender", gender, DbType.String);
					param.Add("buzzStatus", buzzStatus, DbType.Boolean);
					param.Add("notificationToken", notificationToken, DbType.String);
					param.Add("device", device, DbType.String);
					param.Add("allergicTo", allergicTo, DbType.String);
					param.Add("favouriteDishes", favouriteDishes, DbType.String);
					param.Add("fBid", fBid, DbType.String);
					param.Add("prefernce", prefernce, DbType.String);
					param.Add("staffCode", staffCode, DbType.String);
					var objs = await SqlMapper.ExecuteAsync(connection, query, param, commandType: CommandType.StoredProcedure);
					
					return objs;
					
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
		public async Task<int> Update(AspNetUsers model)
		{
			try
			{
				
				using (var connection = connectionFactory.GetConnection)
				{
					var query = "[dbo].AspNetUsers_UPDATE";
					var param = new DynamicParameters();
					param.Add("id", model.Id, DbType.String);
					param.Add("accessFailedCount", model.AccessFailedCount, DbType.Int32);
					param.Add("concurrencyStamp", model.ConcurrencyStamp, DbType.String);
					param.Add("email", model.Email, DbType.String);
					param.Add("emailConfirmed", model.EmailConfirmed, DbType.Boolean);
					param.Add("lockoutEnabled", model.LockoutEnabled, DbType.Boolean);
					param.Add("lockoutEnd", model.LockoutEnd, DbType.DateTimeOffset);
					param.Add("normalizedEmail", model.NormalizedEmail, DbType.String);
					param.Add("normalizedUserName", model.NormalizedUserName, DbType.String);
					param.Add("passwordHash", model.PasswordHash, DbType.String);
					param.Add("phoneNumber", model.PhoneNumber, DbType.String);
					param.Add("phoneNumberConfirmed", model.PhoneNumberConfirmed, DbType.Boolean);
					param.Add("securityStamp", model.SecurityStamp, DbType.String);
					param.Add("twoFactorEnabled", model.TwoFactorEnabled, DbType.Boolean);
					param.Add("userName", model.UserName, DbType.String);
					param.Add("address", model.Address, DbType.String);
					param.Add("cid", model.Cid, DbType.Int32);
					param.Add("city", model.City, DbType.String);
					param.Add("country", model.Country, DbType.String);
					param.Add("dob", model.Dob, DbType.DateTime2);
					param.Add("firstName", model.FirstName, DbType.String);
					param.Add("isActive", model.IsActive, DbType.Boolean);
					param.Add("joinTime", model.JoinTime, DbType.DateTime2);
					param.Add("lastName", model.LastName, DbType.String);
					param.Add("pinCode", model.PinCode, DbType.String);
					param.Add("restaurantID", model.RestaurantID, DbType.Int64);
					param.Add("state", model.State, DbType.String);
					param.Add("userImage", model.UserImage, DbType.String);
					param.Add("isDeleted", model.IsDeleted, DbType.Boolean);
					param.Add("gender", model.Gender, DbType.String);
					param.Add("buzzStatus", model.BuzzStatus, DbType.Boolean);
					param.Add("notificationToken", model.NotificationToken, DbType.String);
					param.Add("device", model.Device, DbType.String);
					param.Add("allergicTo", model.AllergicTo, DbType.String);
					param.Add("favouriteDishes", model.FavouriteDishes, DbType.String);
					param.Add("fBid", model.FBid, DbType.String);
					param.Add("prefernce", model.Prefernce, DbType.String);
					param.Add("staffCode", model.StaffCode, DbType.String);
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
		/// Delete current AspNetUsers from database.
		/// </summary>
		/// <param name="id">System.String</param>
		public async Task<int> Delete(System.String id)
		{
			using (var connection = connectionFactory.GetConnection)
			{
				var query = "[dbo].AspNetUsers_DELETE";
				var param = new DynamicParameters();
				param.Add("id", id, DbType.String);
				var iValue = await SqlMapper.ExecuteAsync(connection, query, param, commandType: CommandType.StoredProcedure);
				return iValue;
				
			}
		}
		#endregion
		
		
	}
}

