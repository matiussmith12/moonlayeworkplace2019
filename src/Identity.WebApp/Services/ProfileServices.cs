using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Identity.WebApp.Models;
using IdentityModel;
using IdentityServer4.Models;
using IdentityWeb.Models;
using Microsoft.AspNetCore.Identity;
using SqlKata.Execution;

namespace Identity.WebApp.Services
{
    public class ProfileServices : IdentityServer4.Services.IProfileService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEWorkConnection _eWorkConnection;

        public ProfileServices(UserManager<ApplicationUser> userManager, IEWorkConnection eWorkConnection)
        {
            _userManager = userManager;
            _eWorkConnection = eWorkConnection;

        }

        public async Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            var user = await _userManager.GetUserAsync(context.Subject);
            var employeeSet = _eWorkConnection.Query("Employees");
            var employee = await employeeSet.Where("Username", "=", user.UserName).Select("Id", "FullName", "Username").FirstOrDefaultAsync<EmployeeEWork>();

            if(employee != null)
            {
                if (!string.IsNullOrEmpty(employee.FullName))
                    context.IssuedClaims.Add(new Claim(JwtClaimTypes.Name, employee.FullName));

                context.IssuedClaims.Add(new Claim("EmployeeId", employee.Id.ToString()));
            }
        }

        public async Task IsActiveAsync(IsActiveContext context)
        {
            var user = await _userManager.GetUserAsync(context.Subject);

            context.IsActive = (user != null);
        }
    }
}
