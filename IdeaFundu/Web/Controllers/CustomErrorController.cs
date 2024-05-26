using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class CustomErrorController : Controller
    {
        [Route("CustomError")]
        public IActionResult ShowError()
        {
            var errorinfo = HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            ViewBag.path = "Hi";
            ViewBag.error = "Bye";
            return View();
        }
    }
}
