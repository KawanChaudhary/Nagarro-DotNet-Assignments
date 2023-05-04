using Microsoft.AspNetCore.Mvc;
using MVCAssignment.Models;
using MVCAssignment.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAssignment.Controllers
{
    public class SignUpController : Controller
    {
        private readonly ISignUpRepository _signUpRespository;

        public SignUpController(ISignUpRepository signUpRepository)
        {
            _signUpRespository = signUpRepository;
        }

        [Route("signup")]
        public IActionResult SignUp()
        {
            return View();
        }

        [Route("signup")]
        [HttpPost]
        public async Task<IActionResult> Signup(SignUpUserModel userModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signUpRespository.CreateUserAsync(userModel);
                if (!result.Succeeded)
                {
                    foreach (var errorMessage in result.Errors)
                    {
                        ModelState.AddModelError("", errorMessage.Description);
                    }

                    return View(userModel);
                }

                ModelState.Clear();
                return RedirectToAction("signin", "SignIn");
            }
            return View();
        }

    }
}
