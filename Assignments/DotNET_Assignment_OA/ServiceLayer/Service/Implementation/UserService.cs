using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using ServiceLayer.Service.Interface;
using System.Security.Claims;

namespace ServiceLayer.Service.Implementation
{
    public class UserService : IUserService
    {
        private readonly IHttpContextAccessor _httpContext;
        private readonly UserManager<ApplicationUser> _userManager;


        public UserService(IHttpContextAccessor httpContext, UserManager<ApplicationUser> userManager)
        {
            _httpContext = httpContext;
            _userManager = userManager;
        }

        public string GetUserId()
        {
            return _httpContext.HttpContext.User?.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public bool IsAuthenticated()
        {
            return _httpContext.HttpContext.User.Identity.IsAuthenticated;
        }

        public string GetEmail()
        {
            return _httpContext.HttpContext.User.Identity.Name;
        }

        public bool IsAdmin()
        {
            if (IsAuthenticated())
            {
                string id = GetUserId();
                var user = _userManager.FindByIdAsync(id);
                return user.Result.IsAdmin;
            }
            return false;
        }

        public string FirstName()
        {
            if (IsAuthenticated())
            {
                string id = GetUserId();
                var user = _userManager.FindByIdAsync(id);
                return user.Result.FirstName;
            }
            return "";
        }

        public string LastName()
        {
            if (IsAuthenticated())
            {
                string id = GetUserId();
                var user = _userManager.FindByIdAsync(id);
                return user.Result.LastName;
            }
            return "";
        }

    }
}
