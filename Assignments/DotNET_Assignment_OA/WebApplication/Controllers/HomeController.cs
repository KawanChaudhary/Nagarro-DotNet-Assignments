using AspNetCoreHero.ToastNotification.Abstractions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.Log;
using ServiceLayer.Logger;
using ServiceLayer.Service.Interface;

namespace WebApplication.Controllers
{

    public class HomeController : Controller
    {
        
        [ActivatorUtilitiesConstructor]
        public HomeController()
        {
            
        }        

        public IActionResult Index()
        {            
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
