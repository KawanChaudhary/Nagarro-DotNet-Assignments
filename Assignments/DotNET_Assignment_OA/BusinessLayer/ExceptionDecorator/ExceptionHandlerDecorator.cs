using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System.Data.Entity.Core.Objects;

namespace BusinessLayer.ExceptionDecorator
{
    public class ExceptionHandlerDecorator : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            // Log the exception
            var logger = context.HttpContext.RequestServices.GetService<ILogger<ExceptionHandlerDecorator>>();
            logger.LogError(context.Exception, "An unhandled exception occurred.");

            // Return a custom error response to the client
            context.Result = new ObjectResult(new { error = "An unexpected error occurred." })
            {
                StatusCode = StatusCodes.Status500InternalServerError
            };
        }
    }
}
