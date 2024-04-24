using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.UserArea.Controllers
{
    public class UserHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
