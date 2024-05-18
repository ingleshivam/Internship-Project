using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repository;
using Repository.ViewModels;

namespace Web.Controllers
{
    public class ManageInvestorsController : Controller
    {
        IInvestor InvestorRepo;
        IState SRepo;
        ICountry CRepo;
        ICity CityRepo;
        public ManageInvestorsController(IInvestor _InvestorRepo,IState _SRepo, ICountry _CRepo, ICity _CityRepo)
        {
            this.InvestorRepo = _InvestorRepo;
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
                var getLoginData = this.InvestorRepo.Login(rec);
                if (getLoginData.IsSuccess)
                {
                    HttpContext.Session.SetString("InvestorID", getLoginData.LoggedInID.ToString());
                    HttpContext.Session.SetString("InvestorName", getLoginData.LoggedInName);
                    string MakeRequestStatus = HttpContext.Session.GetString("MakeRequestStatus");
                    string AskQueryStatus = HttpContext.Session.GetString("AskQueryStatus");
                    if (MakeRequestStatus == "True" && AskQueryStatus == null)
                    {
                        return RedirectToAction("MakeRequest","Home",new {area =""});
                    }else if(MakeRequestStatus == null && AskQueryStatus == "True")
                    {
                        return RedirectToAction("AskQuery","Home",new {area = ""});
                    }
                    else
                    {
                        return RedirectToAction("Index", "Home", new { area = "" }); //Changes -> Controller : InvestorHome, area : InvestorArea
                    }
                    
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
        public ActionResult SignUp(InvestorRegistrationVM rec)
        {
            ViewBag.StateID = new SelectList(this.SRepo.GetAll(), "StateID", "StateName");
            ViewBag.CountryID = new SelectList(this.CRepo.GetAll(), "CountryID", "CountryName");
            ViewBag.CityID = new SelectList(this.CityRepo.GetAll(), "CityID", "CityName");
            if (ModelState.IsValid)
            {
                var res = this.InvestorRepo.SignUp(rec);
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
