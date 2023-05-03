/***************************************************************/
/* Code Writer (written by Anish M Mathew )                                 */
/*                                                                          */
/* This file was automatically generated using Code Writer                  */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated : 2/28/2018 10:51:46 AM                                      */
/*                                                                          */
/* More Details    --                                                       */
/*http://visualstudiogallery.msdn.microsoft.com/40d92d45-107e-4f83-b6c5-50a7e2419389*/
/****************************************************************************/
using DataAccess.Repository;
using System;

using DataAccess.Repository;
namespace DataAccess.UnitOfWork

{
	public interface IUnitOfWork : IDisposable
	{
		
		IAspNetUsersRepository AspNetUsersRepository  { get; }
		ICategoryRepository CategoryRepository { get; }
        void Complete();
		
	}
}

