using Core;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata;
using Repository;
using Repository.ViewModels;
using Web.CustFilter;

namespace Web.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    //[UserAuthroization]
    public class InvestmentRequestController : Controller
    {
        IIVRequest IVRequestRepo;
        public InvestmentRequestController(IIVRequest _IVRequestRepo)
        {
            IVRequestRepo = _IVRequestRepo;
        }

        [NonAction]
        public Int64 GetSessionUserId()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                return Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            }
            return 0;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Accept(Int64 id)
        {
            ViewBag.IVRequestID = id;
            return View();
        }


        [HttpPost]
        public IActionResult Accept(AcceptInvestment rec)
        {
            if (ModelState.IsValid)
            {
                var res = this.IVRequestRepo.AcceptPendingRequest(rec);
                if (res.IsSuccess)
                {
                    TempData["Message"] = res.Message;
                    return RedirectToAction("Index");
                }
                ViewBag.Message = res.Message;
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult ViewAcceptedInv(Int64 id)
        {
            var rec = this.IVRequestRepo.GetInvestmentByRequestID(id);
            return View(rec);
        }
    }
}
