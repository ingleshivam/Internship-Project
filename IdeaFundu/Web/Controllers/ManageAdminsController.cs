﻿using Microsoft.AspNetCore.Mvc;
using Repository;
using Repository.ViewModels;

namespace Web.Controllers
{
    public class ManageAdminsController : Controller
    {
        IAdmin AdminRepo;
        public ManageAdminsController(IAdmin _AdminRepo)
        {
            this.AdminRepo = _AdminRepo;
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
                var getLoginData = this.AdminRepo.Login(rec);
                if (getLoginData.IsSuccess)
                {
                    HttpContext.Session.SetString("AdminID", getLoginData.LoggedInID.ToString());
                    HttpContext.Session.SetString("AdminName", getLoginData.LoggedInName);
                    return RedirectToAction("Index", "AdminHome", new { area = "AdminArea" });
                }
                else
                {
                    ModelState.AddModelError("",getLoginData.ErrorMessage);
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
