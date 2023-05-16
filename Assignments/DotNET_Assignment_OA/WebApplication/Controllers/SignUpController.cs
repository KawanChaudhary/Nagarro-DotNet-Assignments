using DomainLayer.Models;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.Service.Interface;
using ServiceLayer.Service.Validators;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    public class SignUpController : Controller
    {
        private readonly ISignUpRepository _signUpRespository;

        [ActivatorUtilitiesConstructor]
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
            var validator = new SignUpValidator();
            var res = validator.Validate(userModel);

            if (!res.IsValid)
            {
                return BadRequest(res.Errors);
            }

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
