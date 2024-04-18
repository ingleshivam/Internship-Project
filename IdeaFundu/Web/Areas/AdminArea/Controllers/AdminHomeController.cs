using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class AdminHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
