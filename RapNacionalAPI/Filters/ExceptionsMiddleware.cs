using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace RapNacionalAPI.Filters
{
    public class ExceptionsMiddleware : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            context.ExceptionHandled = true;

            context.Result = new JsonResult("Ops, ocorreu um erro") { StatusCode = 500};

        }
    }
}
