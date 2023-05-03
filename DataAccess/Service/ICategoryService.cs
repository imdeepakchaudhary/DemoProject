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
using DataAccess.Entities;


namespace DataAccess.Service
{
	public partial interface ICategoryService
	{
		Task<Category> Get(System.Int32? id);
		Task<IEnumerable<Category>> Search(int pageIndex, int pageSize);
		Task<IEnumerable<Category>> Search(int pageIndex, int pageSize,string sortBy, string orderBy);
		Task<IEnumerable<Category>> Search(System.Int32? id, System.String name, System.String description, System.String status, System.DateTime? ceatedOn, System.String ceatedBy, System.DateTime? updatedOn, System.String updatedBy);
		Task<int> Delete(System.Int32? id);
		Task<System.Int32> Insert(Category model);
		Task<System.Int32> Insert(System.String name, System.String description, System.String status, System.DateTime? ceatedOn, System.String ceatedBy, System.DateTime? updatedOn, System.String updatedBy);
		Task<int> Update(Category model);
		Task<int> Update(System.Int32? id, System.String name, System.String description, System.String status, System.DateTime? ceatedOn, System.String ceatedBy, System.DateTime? updatedOn, System.String updatedBy);
	}
}

