using Microsoft.AspNetCore.Identity;
using MVCAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAssignment.Repository
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
