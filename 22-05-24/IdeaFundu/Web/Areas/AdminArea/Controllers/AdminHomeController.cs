using Microsoft.AspNetCore.Mvc;
using Repository;
using Repository.ViewModels;
using Web.CustFilter;
namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [AdminAuthroization]
    public class AdminHomeController : Controller
    {
        IAdmin Repo;
        public AdminHomeController(IAdmin _Repo)
        {
            Repo = _Repo;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordVM rec)
        {
            if (ModelState.IsValid)
            {
                Int64 cid = Convert.ToInt64(HttpContext.Session.GetString("AdminID"));
                var res = this.Repo.ChangePassword(rec, cid);
                ViewBag.Message = res.Message;
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult EditProfile()
        {
            Int64 cid = Convert.ToInt64(HttpContext.Session.GetString("AdminID"));
            var rec = this.Repo.GetById(cid);
            return View(rec);
        }

        [HttpPost]
        public IActionResult EditProfile(AdminProfileVM rec)
        {
            if (ModelState.IsValid)
            {
                Int64 cid = Convert.ToInt64(HttpContext.Session.GetString("AdminID"));
                var res = this.Repo.EditProfile(rec, cid);
                ViewBag.Message = res.Message;
            }
            return View(rec);
        }
    }
}
