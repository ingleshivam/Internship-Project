using Core;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Identity.Client;
using Repository;
using Repository.ViewModels;
using Web.CustFilter;

namespace Web.Areas.InvestorArea.Controllers
{
    [Area("InvestorArea")]
    //[UserAuthroization]
    public class InvestmentRequestController : Controller
    {
        IIVRequest IVRequestRepo;
        IInvestmentPayment InvestmentPaymentRepo;
        public InvestmentRequestController(IIVRequest _IVRequestRepo,IInvestmentPayment _InvestmentPaymentRepo)
        {
            IVRequestRepo = _IVRequestRepo;
            InvestmentPaymentRepo = _InvestmentPaymentRepo;
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
        public IActionResult ViewDetails(Int64 id)
        {
            var record = this.IVRequestRepo.CheckInvestorPaidAmount(id);
            if (record != null)
            {
                return View("PaymentReport",record);
            }
            else
            {
                var rec = this.IVRequestRepo.GetInvestmentByRequestID(id);
                return View(rec);
            }
        }

        [HttpPost]
        public IActionResult ViewDetails(AcceptInvestmentVM rec)
        {
            if (ModelState.IsValid)
            {
                var r = this.InvestmentPaymentRepo.GetAll().Where(p => p.AcceptIVID == rec.AcceptIVID).ToList(); 
                if(r.Any())
                {
                    TempData["AlreadyInvested"] = "You have already invested in this idea";
                    return View();
                }
                else
                {
                    return RedirectToAction("InvestmentPayment", rec);
                }   
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult InvestmentPayment(AcceptInvestmentVM rec)
        {
            var record = this.InvestmentPaymentRepo.GetInvestmentPaymentDetails(rec);
            return View(record);
        }

        [HttpPost]
        [ActionName("InvestmentPayment")]
        public IActionResult sample(InvestmentPayment rec)
        {
            this.InvestmentPaymentRepo.Add(rec);
            TempData["PaymentSuccessfull"] = "Payment Successfull";
            return RedirectToAction("Index");
        }
    }
}
