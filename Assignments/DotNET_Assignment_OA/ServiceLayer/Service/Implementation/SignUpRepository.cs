using DomainLayer.Models;
using Microsoft.AspNetCore.Identity;
using ServiceLayer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceLayer.Service.Implementation
{
    public class SignUpRepository : ISignUpRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;


        public SignUpRepository(UserManager<ApplicationUser> userManager)
        {            
            _userManager = userManager;
        }
        public async Task<IdentityResult> CreateUserAsync(SignUpUserModel userModel)
        {
            var user = new ApplicationUser()
            {
                FirstName = userModel.FirstName,
                LastName = userModel.LastName,
                Email = userModel.Email,
                UserName = userModel.Email,
                CheckPassword = userModel.Password
            };
            var result = await _userManager.CreateAsync(user, userModel.Password);
            return result;
        }

    }
}
