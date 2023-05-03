 
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
		public async Task<IEnumerable<AspNetUsers>> Search(int pageIndex, int pageSize,string sortBy, string orderBy, string Search)
		{

            using (var connection = connectionFactory.GetConnection)
            {
                var query = "[dbo].AspNetUsers_CUSTOM_SEARCH";
                var param = new DynamicParameters();
                param.Add("@PageIndex", pageIndex);
                param.Add("@PageSize", pageSize);
                param.Add("@sortBy", sortBy);
                param.Add("@orderBy", orderBy);
                param.Add("@searchkey", Search);

                var list = await SqlMapper.QueryAsync<AspNetUsers>(connection, query, param, commandType: CommandType.StoredProcedure);

                if (list == null)
                    return null;
                else
                    return list;

            }
		}

        public async Task<IEnumerable<AspNetUsers>> Search(int pageIndex, int pageSize, string sortBy, string orderBy, string Search, int CID, int RestaurantID)
        {

            using (var connection = connectionFactory.GetConnection)
            {
                var query = "[dbo].AspNetUsers_CUSTOM_PANEL";
                var param = new DynamicParameters();
                param.Add("@PageIndex", pageIndex);
                param.Add("@PageSize", pageSize);
                param.Add("@sortBy", sortBy);
                param.Add("@orderBy", orderBy);
                param.Add("@searchkey", Search);
                param.Add("@CID", CID);
                param.Add("@RestaurantID", RestaurantID);
                var list = await SqlMapper.QueryAsync<AspNetUsers>(connection, query, param, commandType: CommandType.StoredProcedure);

                if (list == null)
                    return null;
                else
                    return list;

            }
        }


        public async Task<IEnumerable<AspNetUsers>> Search(int pageIndex, int pageSize, string sortBy, string orderBy, string Search, int CID)
        {

            using (var connection = connectionFactory.GetConnection)
            {
                var query = "[dbo].AspNetUsers_CUSTOM_SEARCH_COMPANY";
                var param = new DynamicParameters();
                param.Add("@PageIndex", pageIndex);
                param.Add("@PageSize", pageSize);
                param.Add("@sortBy", sortBy);
                param.Add("@orderBy", orderBy);
                param.Add("@searchkey", Search);
                param.Add("@cid", CID);

                var list = await SqlMapper.QueryAsync<AspNetUsers>(connection, query, param, commandType: CommandType.StoredProcedure);

                if (list == null)
                    return null;
                else
                    return list;

            }
        }

        public async Task<AspNetUsers> Get2(System.String id)
        {
            using (var connection = connectionFactory.GetConnection)
            {
                var query = "[dbo].AspNetUsers_SELECT2";
                var param = new DynamicParameters();
                param.Add(@"id", id, DbType.String);
                var list = await SqlMapper.QueryAsync<AspNetUsers>(connection, query, param, commandType: CommandType.StoredProcedure);
                return list.FirstOrDefault();

            }
        }


        public async Task<IEnumerable<AspNetUsers>> getAnalytilsList(int pageIndex, int pageSize, string sortBy, string orderBy, string searchstring, DateTime? dateFrom, DateTime? dateTo, long RestoId)
        {

            using (var connection = connectionFactory.GetConnection)
            {
                var query = "[dbo].AnalyticsListData";
                var param = new DynamicParameters();
                param.Add("@PageIndex", pageIndex);
                param.Add("@PageSize", pageSize);
                param.Add("@sortBy", sortBy);
                param.Add("@orderBy", orderBy);
                param.Add("@searchstring", searchstring);
                param.Add("@dateFrom", dateFrom);
                param.Add("@dateTo", dateTo);
                param.Add("@RestoId", RestoId);

                var list = await SqlMapper.QueryAsync<AspNetUsers>(connection, query, param, commandType: CommandType.StoredProcedure);

                if (list == null)
                    return null;
                else
                    return list;

            }
        }

        public async Task<IEnumerable<AspNetUsers>> getAnalytilsCSV(string sortBy, string orderBy, string searchstring, DateTime? dateFrom, DateTime? dateTo, long RestoId)
        {

            using (var connection = connectionFactory.GetConnection)
            {
                var query = "[dbo].AnalyticsListCSVData";
                var param = new DynamicParameters();
                param.Add("@sortBy", sortBy);
                param.Add("@orderBy", orderBy);
                param.Add("@searchstring", searchstring);
                param.Add("@dateFrom", dateFrom);
                param.Add("@dateTo", dateTo);
                param.Add("@RestoId", RestoId);

                var list = await SqlMapper.QueryAsync<AspNetUsers>(connection, query, param, commandType: CommandType.StoredProcedure);

                if (list == null)
                    return null;
                else
                    return list;

            }
        }

        public async Task<AspNetUsers> getUserAnalytics(string userid)
        {

            using (var connection = connectionFactory.GetConnection)
            {
                var query = "[dbo].getUserAnalytics";
                var param = new DynamicParameters();
                param.Add("@userid", userid);

                var list = await SqlMapper.QueryAsync<AspNetUsers>(connection, query, param, commandType: CommandType.StoredProcedure);

                if (list == null)
                    return null;
                else
                    return list.FirstOrDefault();

            }
        }

        public async Task<AspNetUsers> GetUserByPhone(string phonenumber)
        {

            using (var connection = connectionFactory.GetConnection)
            {
                var query = "[dbo].GetUserByPhone";
                var param = new DynamicParameters();
                param.Add("@phonenumber", phonenumber);

                var list = await SqlMapper.QueryAsync<AspNetUsers>(connection, query, param, commandType: CommandType.StoredProcedure);

                if (list == null)
                    return null;
                else
                    return list.FirstOrDefault();

            }
        }

        public async Task<AspNetUsers> getByFbId(string id)
        {

            using (var connection = connectionFactory.GetConnection)
            {
                var query = "[dbo].getByFbId";
                var param = new DynamicParameters();
                param.Add("@id", id);

                var list = await SqlMapper.QueryAsync<AspNetUsers>(connection, query, param, commandType: CommandType.StoredProcedure);

                if (list == null)
                    return null;
                else
                    return list.FirstOrDefault();

            }
        }


        public async Task<IEnumerable<AspNetUsers>> GetStaff(long RestoId)
        {

            using (var connection = connectionFactory.GetConnection)
            {
                var query = "[dbo].GetStaff";
                var param = new DynamicParameters();
                param.Add("@RestoId", RestoId);

                var list = await SqlMapper.QueryAsync<AspNetUsers>(connection, query, param, commandType: CommandType.StoredProcedure);

                if (list == null)
                    return null;
                else
                    return list;

            }
        }

        public async Task<int> UpdateToken(System.String id, System.String notificationToken, System.String device)
        {
            try
            {

                using (var connection = connectionFactory.GetConnection)
                {
                    var query = "[dbo].UpdateToken";
                    var param = new DynamicParameters();
                    param.Add("@id", id);
                    param.Add("@token", notificationToken);
                    param.Add("@device", device);
                    var objs = await SqlMapper.ExecuteAsync(connection, query, param, commandType: CommandType.StoredProcedure);
                    return objs;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<int> UpdateUserid(System.String id, System.String phoneNumber)
        {
            try
            {

                using (var connection = connectionFactory.GetConnection)
                {
                    var query = "[dbo].updateTablememberUserid";
                    var param = new DynamicParameters();
                    param.Add("@Userid", id);
                    param.Add("@PhoneNumber", phoneNumber);
                    var objs = await SqlMapper.ExecuteAsync(connection, query, param, commandType: CommandType.StoredProcedure);
                    return objs;

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

