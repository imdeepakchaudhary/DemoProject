/***************************************************************/
/* Code Writer (written by Anish M Mathew )                                 */
/*                                                                          */
/* This file was automatically generated using Code Writer                  */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated : 3/6/2018 3:54:41 PM                                      */
/*                                                                          */
/* More Details    --                                                       */
/*http://visualstudiogallery.msdn.microsoft.com/40d92d45-107e-4f83-b6c5-50a7e2419389*/
/****************************************************************************/
using DataAccess.Infrastructure;
namespace DataAccess.Repository
{
	public abstract class BaseRepository
	{
		protected readonly IConnectionFactory connectionFactory;
		public BaseRepository(IConnectionFactory connectionFactory)
		{
			this.connectionFactory = connectionFactory;
		}
	}
}

