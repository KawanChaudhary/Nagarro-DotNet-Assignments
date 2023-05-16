using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.Logger;

namespace WebApplication.Controllers
{

    public class HomeController : Controller
    {
        private ILog _ILog;

        [ActivatorUtilitiesConstructor]
        public HomeController()
        {
            _ILog = Log.GetInstance;
        }
       /* protected override void OnException(ExceptionContext filterContext)
        {
            //First, Log the Exception Details
            _ILog.LogException(filterContext.Exception.ToString());
            //Then set that the Exception is Handled
            filterContext.ExceptionHandled = true;
            //Then Redirect to the Error view
            this.View("Error").ExecuteResult(this.ControllerContext);
        }*/

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
