using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repository;
using Repository.ViewModels;

namespace Web.Controllers
{
    public class ManageUsersController : Controller
    {
        IUser UserRepo;
        IState SRepo;
        ICountry CRepo;
        ICity CityRepo;
        public ManageUsersController(IUser _UserRepo,IState _SRepo, ICountry _CRepo, ICity _CityRepo)
        {
            this.UserRepo = _UserRepo;
            this.CRepo = _CRepo;
            this.SRepo = _SRepo;
            this.CityRepo = _CityRepo;
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(LoginVM rec)
        {
            if (ModelState.IsValid)
            {
                var getLoginData = this.UserRepo.Login(rec);
                if (getLoginData.IsSuccess)
                {
                    HttpContext.Session.SetString("UserID", getLoginData.LoggedInID.ToString());
                    HttpContext.Session.SetString("UserName", getLoginData.LoggedInName);
                    return RedirectToAction("Index", "UserHome", new { area = "UserArea" });
                }
                else
                {
                    ModelState.AddModelError("", getLoginData.ErrorMessage);
                    return View(rec);
                }

            }
            return View(rec);
        }

        [HttpGet]
        public ActionResult SignUp()
        {
            ViewBag.StateID = new SelectList(this.SRepo.GetAll(), "StateID", "StateName");
            ViewBag.CountryID = new SelectList(this.CRepo.GetAll(), "CountryID", "CountryName");
            ViewBag.CityID = new SelectList(this.CityRepo.GetAll(), "CityID", "CityName");
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(UserRegistrationVM rec)
        {
            ViewBag.StateID = new SelectList(this.SRepo.GetAll(), "StateID", "StateName");
            ViewBag.CountryID = new SelectList(this.CRepo.GetAll(), "CountryID", "CountryName");
            ViewBag.CityID = new SelectList(this.CityRepo.GetAll(), "CityID", "CityName");
            if (ModelState.IsValid)
            {
                var res = this.UserRepo.SignUp(rec);
                if (res.IsSuccess)
                {
                    return RedirectToAction("SignIn");
                }
                else
                {
                    ModelState.AddModelError("", res.Message);
                    return View(rec);
                }
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult SignOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("SignIn");
        }
    }
}
