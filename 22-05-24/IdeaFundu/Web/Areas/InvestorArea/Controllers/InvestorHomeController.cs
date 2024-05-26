using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.InvestorArea.Controllers
{
    [Area("InvestorArea")]
    //[InvestorAuthroization]
    public class InvestorHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
