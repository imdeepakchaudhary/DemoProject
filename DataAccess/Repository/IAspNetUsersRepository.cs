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
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Entities;


namespace DataAccess.Repository
{
	public partial interface IAspNetUsersRepository
	{
		Task<AspNetUsers> Get(System.String id);
		Task<AspNetUsers> Get(System.String id,int CID);
		Task<IEnumerable<AspNetUsers>> Search(int pageIndex, int pageSize);
		Task<IEnumerable<AspNetUsers>> Search(int pageIndex, int pageSize,string sortBy, string orderBy);
		
		Task<IEnumerable<AspNetUsers>> Search(int pageIndex, int pageSize,int CID);
		Task<IEnumerable<AspNetUsers>> Search(int pageIndex, int pageSize,string sortBy, string orderBy,int CID);
		Task<IEnumerable<AspNetUsers>> Search(System.String id, System.Int32? accessFailedCount, System.String concurrencyStamp, System.String email, System.Boolean? emailConfirmed, System.Boolean? lockoutEnabled, System.DateTimeOffset lockoutEnd, System.String normalizedEmail, System.String normalizedUserName, System.String passwordHash, System.String phoneNumber, System.Boolean? phoneNumberConfirmed, System.String securityStamp, System.Boolean? twoFactorEnabled, System.String userName, System.String address, System.Int32? cid, System.String city, System.String country, System.DateTime? dob, System.String firstName, System.Boolean? isActive, System.DateTime? joinTime, System.String lastName, System.String pinCode, System.Int64? restaurantID, System.String state, System.String userImage, System.Boolean? isDeleted, System.String gender, System.Boolean? buzzStatus, System.String notificationToken, System.String device, System.String allergicTo, System.String favouriteDishes, System.String fBid, System.String prefernce, System.String staffCode);
		Task<int> Delete(System.String id);
		Task<int> Insert(AspNetUsers model);
		Task<int> Insert(System.String id, System.Int32? accessFailedCount, System.String concurrencyStamp, System.String email, System.Boolean? emailConfirmed, System.Boolean? lockoutEnabled, System.DateTimeOffset lockoutEnd, System.String normalizedEmail, System.String normalizedUserName, System.String passwordHash, System.String phoneNumber, System.Boolean? phoneNumberConfirmed, System.String securityStamp, System.Boolean? twoFactorEnabled, System.String userName, System.String address, System.Int32? cid, System.String city, System.String country, System.DateTime? dob, System.String firstName, System.Boolean? isActive, System.DateTime? joinTime, System.String lastName, System.String pinCode, System.Int64? restaurantID, System.String state, System.String userImage, System.Boolean? isDeleted, System.String gender, System.Boolean? buzzStatus, System.String notificationToken, System.String device, System.String allergicTo, System.String favouriteDishes, System.String fBid, System.String prefernce, System.String staffCode);
		Task<int> Update(AspNetUsers model);
		Task<int> Update(System.String id, System.Int32? accessFailedCount, System.String concurrencyStamp, System.String email, System.Boolean? emailConfirmed, System.Boolean? lockoutEnabled, System.DateTimeOffset lockoutEnd, System.String normalizedEmail, System.String normalizedUserName, System.String passwordHash, System.String phoneNumber, System.Boolean? phoneNumberConfirmed, System.String securityStamp, System.Boolean? twoFactorEnabled, System.String userName, System.String address, System.Int32? cid, System.String city, System.String country, System.DateTime? dob, System.String firstName, System.Boolean? isActive, System.DateTime? joinTime, System.String lastName, System.String pinCode, System.Int64? restaurantID, System.String state, System.String userImage, System.Boolean? isDeleted, System.String gender, System.Boolean? buzzStatus, System.String notificationToken, System.String device, System.String allergicTo, System.String favouriteDishes, System.String fBid, System.String prefernce, System.String staffCode);
		
	}
}

