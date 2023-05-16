using DomainLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.Service.Interface;
using ServiceLayer.Service.Validators;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    public class SignInController : Controller
    {
        private readonly ISignInRepository _accountRepository;

        public SignInController(ISignInRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        [ActivatorUtilitiesConstructor]
        public SignInController(ISignInRepository accountRepository, SignInManager<ApplicationUser> @object)
        {
            _accountRepository = accountRepository;
        }

        [Route("signin")]
        public IActionResult SignIn()
        {
            return View();
        }

        [Route("signin")]
        [HttpPost]
        public async Task<IActionResult> SignIn(SignInUserModel userModel, string returnUrl)
        {
            var validator = new SignInValidator();
            var res = validator.Validate(userModel);

            if (!res.IsValid)
            {
                return BadRequest(res.Errors);
            }

            if (ModelState.IsValid)
            {
                var result = await _accountRepository.PasswordSignInAsync(userModel);
                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Invalid Credentials");
            }
            return View(userModel);
        }

        [Route("signout")]
        public async Task<IActionResult> SignOut()
        {
            await _accountRepository.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
