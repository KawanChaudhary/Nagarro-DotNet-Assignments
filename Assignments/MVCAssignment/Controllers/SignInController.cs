using Microsoft.AspNetCore.Mvc;
using MVCAssignment.Models;
using MVCAssignment.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAssignment.Controllers
{
    public class SignInController : Controller
    {
        private readonly ISignInRepository _accountRepository;

        public SignInController(ISignInRepository accountRepository)
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
            if (ModelState.IsValid)
            {
                var res = await _accountRepository.PasswordSignInAsync(userModel);
                if (res.Succeeded)
                {
                    if (!string.IsNullOrEmpty(returnUrl))
                    {
                        return LocalRedirect(returnUrl);
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
