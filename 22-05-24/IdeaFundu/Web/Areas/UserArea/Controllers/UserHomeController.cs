using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NuGet.Protocol.Plugins;
using Repository;
using Repository.ViewModels;
using Web.CustFilter;

namespace Web.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    [UserAuthroization]
    public class UserHomeController : Controller
    {
        IUser Repo;
        IState SRepo;
        ICountry CRepo;
        ICity CityRepo;
        public UserHomeController (IUser _Repo,IState _SRepo, ICountry _CRepo, ICity _CityRepo)
        {
            Repo = _Repo;
            SRepo = _SRepo;
            CRepo = _CRepo;
            CityRepo = _CityRepo;
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
                Int64 cid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
                var res = this.Repo.ChangePassword(rec, cid);
                ViewBag.Message = res.Message;
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult EditProfile()
        {
            Int64 cid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            var rec = this.Repo.GetById(cid);
            ViewBag.StateID = new SelectList(this.SRepo.GetAll(), "StateID", "StateName");
            ViewBag.CountryID = new SelectList(this.CRepo.GetAll(), "CountryID", "CountryName");
            ViewBag.CityID = new SelectList(this.CityRepo.GetAll(), "CityID", "CityName",rec.CityID);
            return View(rec);
        }

        [HttpPost]
        public IActionResult EditProfile(UserProfileVM rec)
        {
            if (ModelState.IsValid)
            {
                Int64 cid = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
                var res = this.Repo.EditProfile(rec, cid);
                ViewBag.Message = res.Message;
            }
            return View(rec);
        }
    }
}
