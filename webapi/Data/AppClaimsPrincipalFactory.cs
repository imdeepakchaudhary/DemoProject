using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Threading.Tasks;
using webapi.Data;

namespace webapi
{
    public class AppClaimsPrincipalFactory : UserClaimsPrincipalFactory<ApplicationUser, IdentityRole>
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public AppClaimsPrincipalFactory(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IOptions<IdentityOptions> optionsAccessor) : base(userManager, roleManager, optionsAccessor)
        {
            _userManager = userManager;
        }

        public async override Task<ClaimsPrincipal> CreateAsync(ApplicationUser user)
        {
            var principal = await base.CreateAsync(user);

            ((ClaimsIdentity)principal.Identity).AddClaims(
                new[] {
                   
                     new Claim(ClaimTypes.GivenName, (user.FirstName != null ? user.FirstName  + " " +(user.LastName != null ? user.LastName : ""): "")),
                     new Claim(ClaimTypes.Actor, ( string.IsNullOrEmpty(user.UserImage) != true ? user.UserImage :"avatar.png"))
                    
                }
             );

            ////var roles = await _userManager.GetRolesAsync(user);
            ////if (roles.Contains("admin") || roles.Contains("manager"))
            //// {
            //var dd = new DataAccess.Repository.CompanyMasterRepository(new DataAccess.Infrastructure.ConnectionFactory());
            //var company = await dd.Get(user.CID);
            //if (company != null)
            //{
            //    ((ClaimsIdentity)principal.Identity).AddClaims(
            //    new[] {
            //        new Claim("CompanyName", company.CompanyName),
            //        new Claim("CompanyLogo", ( string.IsNullOrEmpty(company.LogoImage) != true ? company.LogoImage :"avatar.png"))});
            //}
            ////}

            /*
            string retID = "";
            ((ClaimsIdentity)principal.Identity).AddClaims(
               new[] {
                    new Claim("RestId", retID),
                    new Claim(ClaimTypes.GivenName, (user.FirstName != null ? user.FirstName : "")),
                    new Claim(ClaimTypes.Actor, ( user.UserImage != null ? user.UserImage :"avatar.png")),
                    new Claim(ClaimTypes.GroupSid, user.CID.ToString()),
               }
            );*/

            return principal;
        }
    }
}
