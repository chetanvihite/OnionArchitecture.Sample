using System.Net;
using System.Web.Mvc;

namespace OnionArchitecture.Sample.Plumbing
{
    /// <summary>
    /// Translates exceptions into brief json result and also modifies HttpStatus code to 500.
    /// </summary>
    public sealed class JsonErrorFilterAttribute : FilterAttribute, IExceptionFilter
    {
        void IExceptionFilter.OnException(ExceptionContext filterContext)
        {
            if (filterContext.HttpContext.Request.IsAjaxRequest())
            {
                // Log.Error(filterContext.Exception);
                filterContext.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError; // 500;
                filterContext.ExceptionHandled = true;
                filterContext.Result = new JsonResult
                {
                    Data = new
                    {
                        status = "error",
                        errorMessage = filterContext.Exception.Message
                    },
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet
                };
            }
        }
    }
}