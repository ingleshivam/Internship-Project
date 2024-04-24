using Core;
using Microsoft.AspNetCore.Mvc;
using Repository;
using Repository.ViewModels;

namespace Web.Controllers
{
    public class ManageUsersController : Controller
    {
        IUser UserRepo;
        public ManageUsersController(IUser _UserRepo)
        {
            this.UserRepo = _UserRepo;
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
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(User rec)
        {
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
