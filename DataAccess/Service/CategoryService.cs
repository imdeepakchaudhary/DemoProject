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
using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Infrastructure;
using DataAccess.UnitOfWork;
using DataAccess.Entities;

namespace DataAccess.Service
{
	public partial class CategoryService : ICategoryService
	{
		IUnitOfWork _unitOfWork;
		public CategoryService(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}
		public async Task<Category> Get(System.Int32? id)
		{
			return await _unitOfWork.CategoryRepository.Get(id);
		}
		public async Task<int> Delete(System.Int32? id)
		{
			return await _unitOfWork.CategoryRepository.Delete(id);
		}
		public async Task<IEnumerable<Category>> Search(int pageIndex, int pageSize)
		{
			return await _unitOfWork.CategoryRepository.Search(pageIndex, pageSize);
		}
		public async Task<IEnumerable<Category>> Search(int pageIndex, int pageSize,string sortBy, string orderBy)
		{
			return await _unitOfWork.CategoryRepository.Search(pageIndex, pageSize,sortBy,orderBy);
		}
		public async Task<IEnumerable<Category>> Search(System.Int32? id, System.String name, System.String description, System.String status, System.DateTime? ceatedOn, System.String ceatedBy, System.DateTime? updatedOn, System.String updatedBy)
		{
			return await _unitOfWork.CategoryRepository.Search(id, name, description, status, ceatedOn, ceatedBy, updatedOn, updatedBy);
		}
		public async Task<System.Int32> Insert(Category usermodel)
		{
			return await _unitOfWork.CategoryRepository.Insert(usermodel);
		}
		public async Task<System.Int32> Insert(System.String name, System.String description, System.String status, System.DateTime? ceatedOn, System.String ceatedBy, System.DateTime? updatedOn, System.String updatedBy)
		{
			return await _unitOfWork.CategoryRepository.Insert(name, description, status, ceatedOn, ceatedBy, updatedOn, updatedBy);
		}
		public async Task<int> Update(Category usermodel)
		{
			return await _unitOfWork.CategoryRepository.Update(usermodel);
		}
		public async Task<int> Update(System.Int32? id, System.String name, System.String description, System.String status, System.DateTime? ceatedOn, System.String ceatedBy, System.DateTime? updatedOn, System.String updatedBy)
		{
			return await _unitOfWork.CategoryRepository.Update(id, name, description, status, ceatedOn, ceatedBy, updatedOn, updatedBy);
		}
	}
}

