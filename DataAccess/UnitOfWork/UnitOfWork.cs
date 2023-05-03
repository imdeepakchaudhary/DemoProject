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
using System;

using DataAccess.Repository;
using DataAccess.Infrastructure;
using DataAccess.UnitOfWork;

namespace Tabon.DataAccess.UnitOfWork
{
	
	public class UnitOfWork : IUnitOfWork
	{
        public IConnectionFactory _connectionFactory;
        public IAspNetUsersRepository _aspnetusersRepository;
        public ICategoryRepository _categoryRepository;

        public UnitOfWork(IConnectionFactory connectionFactory)
		{
			_connectionFactory = connectionFactory;
		}
       
        public IAspNetUsersRepository AspNetUsersRepository
		{
			get
			{
				if (_aspnetusersRepository == null)
				{
					_aspnetusersRepository = new AspNetUsersRepository(_connectionFactory);
				}
				return _aspnetusersRepository;
			}
		}
        public ICategoryRepository CategoryRepository
        {
            get
            {
                if (_categoryRepository == null)
                {
                    _categoryRepository = new CategoryRepository(_connectionFactory);
                }
                return _categoryRepository;
            }
        }


        void IUnitOfWork.Complete()
		{
			throw new NotImplementedException();
		}
		#region IDisposable Support
		
		private bool disposedValue = false; // To detect redundant calls
		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			
			{
				if (disposing)
				{
					// TODO: dispose managed state (managed objects).
				}
				// TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
				// TODO: set large fields to null.
				disposedValue = true;
			}
		}
		
		// TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
		// ~UnitOfWork() {
		//   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
		//   Dispose(false);
		// }
		// This code added to correctly implement the disposable pattern.
		void IDisposable.Dispose()
		{
			// Do not change this code. Put cleanup code in Dispose(bool disposing) above.
			Dispose(true);
			// TODO: uncomment the following line if the finalizer is overridden above.
			// GC.SuppressFinalize(this);
		}
		#endregion
	}
}

