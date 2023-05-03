using Azure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace webapi.Controllers
{
    public class BaseController : Controller
    {
        public string FullName;
        public string Email;
        public string UserID;



        public override async Task OnActionExecutionAsync(ActionExecutingContext Context, ActionExecutionDelegate next)
        {
            var claims = ((System.Security.Claims.ClaimsIdentity)Context.HttpContext.User.Identity).Claims;
            if (claims.Count() > 1)
            {
                UserID = claims.SingleOrDefault(m => m.Type == "UserId").Value;
              //  FullName = claims.SingleOrDefault(m => m.Type == "Sub").Value;
               // Email = claims.SingleOrDefault(m => m.Type == "Email").Value;

            }
             await base.OnActionExecutionAsync(Context, next);
        }
    }
}
