using DataAccess.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using DataAccess.UnitOfWork;
using webapi.Data;
using webapi.Models;

namespace webapi.Controllers
{
    [Authorize]
    [Route("api/[controller]/[action]/{id?}")]
    [ApiController]
    public class CategoryController:BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpPost]
        public async Task<JsonResult> index([ModelBinder] CategoryModel categoryModel)
        {
            if (ModelState.IsValid)
            {
                if (categoryModel.Id != null)
                {
                    var data = await _unitOfWork.CategoryRepository.Get(categoryModel.Id);
                    data.Name = categoryModel.Name;
                    data.Description = categoryModel.Description;
                    data.UpdatedOn = DateTime.Now;
                    data.UpdatedBy = UserID;
                    await _unitOfWork.CategoryRepository.Update(data);
                }
                else
                {
                    var obj = new Category()
                    {
                        Name = categoryModel.Name,
                        Description = categoryModel.Description,
                        CeatedBy = UserID,
                        CeatedOn = DateTime.Now
                    };
                    await _unitOfWork.CategoryRepository.Insert(obj);
                }

            }
            return Json(categoryModel);
        }

        [HttpGet]
        public async Task<IActionResult> get(int id)
        {
            var data =await _unitOfWork.CategoryRepository.Get(id);
            return Json(data);
        }
        [HttpGet]
        public async Task<IActionResult> Search(int pageindex, int pagesize)
        {
            try
            {
                var data = await _unitOfWork.CategoryRepository.Search(Convert.ToInt32(pageindex), Convert.ToInt32(pagesize));

                var iData = data.Select(o => new 
                {
                    usercodeid = o.Id.ToString(),
                    name = o.Name,
                    status = o.Status,
                    TotalPages = o.TotalRecord,
                  //  Image = o.Image != null && o.Image != "" ? (o.Image.StartsWith("http") || o.Image.StartsWith("https")) ? o.Image : General.GetImageUrl("/uploads/ProfileImage/" + o.Image, config) : General.GetImageUrl("/images/profile-pic.png", config)
                });

                return Json(iData);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return null;
        }

       
    }
   
}
