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
using DataAccess.Infrastructure;
using DataAccess.UnitOfWork;
using DataAccess.Entities;

namespace DataAccess.Service
{
	public partial class AspNetUsersService : IAspNetUsersService
	{
		IUnitOfWork _unitOfWork;
		public AspNetUsersService(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}
		public async Task<AspNetUsers> Get(System.String id)
		{
			return await _unitOfWork.AspNetUsersRepository.Get(id);
		}
		public async Task<AspNetUsers> Get(System.String id,int CID)
		{
			return await _unitOfWork.AspNetUsersRepository.Get(id,CID);
		}
		public async Task<int> Delete(System.String id)
		{
			return await _unitOfWork.AspNetUsersRepository.Delete(id);
		}
		public async Task<IEnumerable<AspNetUsers>> Search(int pageIndex, int pageSize)
		{
			return await _unitOfWork.AspNetUsersRepository.Search(pageIndex, pageSize);
		}
		public async Task<IEnumerable<AspNetUsers>> Search(int pageIndex, int pageSize,string sortBy, string orderBy)
		{
			return await _unitOfWork.AspNetUsersRepository.Search(pageIndex, pageSize,sortBy,orderBy);
		}
		public async Task<IEnumerable<AspNetUsers>> Search(int pageIndex, int pageSize,int CID)
		{
			return await _unitOfWork.AspNetUsersRepository.Search(pageIndex, pageSize, CID);
		}
		public async Task<IEnumerable<AspNetUsers>> Search(int pageIndex, int pageSize,string sortBy, string orderBy,int CID)
		{
			return await _unitOfWork.AspNetUsersRepository.Search(pageIndex, pageSize,sortBy,orderBy, CID);
		}
		public async Task<IEnumerable<AspNetUsers>> Search(System.String id, System.Int32? accessFailedCount, System.String concurrencyStamp, System.String email, System.Boolean? emailConfirmed, System.Boolean? lockoutEnabled, System.DateTimeOffset lockoutEnd, System.String normalizedEmail, System.String normalizedUserName, System.String passwordHash, System.String phoneNumber, System.Boolean? phoneNumberConfirmed, System.String securityStamp, System.Boolean? twoFactorEnabled, System.String userName, System.String address, System.Int32? cid, System.String city, System.String country, System.DateTime? dob, System.String firstName, System.Boolean? isActive, System.DateTime? joinTime, System.String lastName, System.String pinCode, System.Int64? restaurantID, System.String state, System.String userImage, System.Boolean? isDeleted, System.String gender, System.Boolean? buzzStatus, System.String notificationToken, System.String device, System.String allergicTo, System.String favouriteDishes, System.String fBid, System.String prefernce, System.String staffCode)
		{
			return await _unitOfWork.AspNetUsersRepository.Search(id, accessFailedCount, concurrencyStamp, email, emailConfirmed, lockoutEnabled, lockoutEnd, normalizedEmail, normalizedUserName, passwordHash, phoneNumber, phoneNumberConfirmed, securityStamp, twoFactorEnabled, userName, address, cid, city, country, dob, firstName, isActive, joinTime, lastName, pinCode, restaurantID, state, userImage, isDeleted, gender, buzzStatus, notificationToken, device, allergicTo, favouriteDishes, fBid, prefernce, staffCode);
		}
		public async Task<int> Insert(AspNetUsers usermodel)
		{
			return await _unitOfWork.AspNetUsersRepository.Insert(usermodel);
		}
		public async Task<int> Insert(System.String id, System.Int32? accessFailedCount, System.String concurrencyStamp, System.String email, System.Boolean? emailConfirmed, System.Boolean? lockoutEnabled, System.DateTimeOffset lockoutEnd, System.String normalizedEmail, System.String normalizedUserName, System.String passwordHash, System.String phoneNumber, System.Boolean? phoneNumberConfirmed, System.String securityStamp, System.Boolean? twoFactorEnabled, System.String userName, System.String address, System.Int32? cid, System.String city, System.String country, System.DateTime? dob, System.String firstName, System.Boolean? isActive, System.DateTime? joinTime, System.String lastName, System.String pinCode, System.Int64? restaurantID, System.String state, System.String userImage, System.Boolean? isDeleted, System.String gender, System.Boolean? buzzStatus, System.String notificationToken, System.String device, System.String allergicTo, System.String favouriteDishes, System.String fBid, System.String prefernce, System.String staffCode)
		{
			return await _unitOfWork.AspNetUsersRepository.Insert(id, accessFailedCount, concurrencyStamp, email, emailConfirmed, lockoutEnabled, lockoutEnd, normalizedEmail, normalizedUserName, passwordHash, phoneNumber, phoneNumberConfirmed, securityStamp, twoFactorEnabled, userName, address, cid, city, country, dob, firstName, isActive, joinTime, lastName, pinCode, restaurantID, state, userImage, isDeleted, gender, buzzStatus, notificationToken, device, allergicTo, favouriteDishes, fBid, prefernce, staffCode);
		}
		public async Task<int> Update(AspNetUsers usermodel)
		{
			return await _unitOfWork.AspNetUsersRepository.Update(usermodel);
		}
		public async Task<int> Update(System.String id, System.Int32? accessFailedCount, System.String concurrencyStamp, System.String email, System.Boolean? emailConfirmed, System.Boolean? lockoutEnabled, System.DateTimeOffset lockoutEnd, System.String normalizedEmail, System.String normalizedUserName, System.String passwordHash, System.String phoneNumber, System.Boolean? phoneNumberConfirmed, System.String securityStamp, System.Boolean? twoFactorEnabled, System.String userName, System.String address, System.Int32? cid, System.String city, System.String country, System.DateTime? dob, System.String firstName, System.Boolean? isActive, System.DateTime? joinTime, System.String lastName, System.String pinCode, System.Int64? restaurantID, System.String state, System.String userImage, System.Boolean? isDeleted, System.String gender, System.Boolean? buzzStatus, System.String notificationToken, System.String device, System.String allergicTo, System.String favouriteDishes, System.String fBid, System.String prefernce, System.String staffCode)
		{
			return await _unitOfWork.AspNetUsersRepository.Update(id, accessFailedCount, concurrencyStamp, email, emailConfirmed, lockoutEnabled, lockoutEnd, normalizedEmail, normalizedUserName, passwordHash, phoneNumber, phoneNumberConfirmed, securityStamp, twoFactorEnabled, userName, address, cid, city, country, dob, firstName, isActive, joinTime, lastName, pinCode, restaurantID, state, userImage, isDeleted, gender, buzzStatus, notificationToken, device, allergicTo, favouriteDishes, fBid, prefernce, staffCode);
		}
	}
}

