//using Core;
//using Humanizer;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore.Metadata;
//using Repository;
//using Repository.ViewModels;
//using Web.CustFilter;

//namespace Web.Areas.InvestorArea.Controllers
//{
//    [Area("InvestorArea")]
//    //[UserAuthroization]
//    public class InvestmentPaymentController : Controller
//    {
//        IInvestmentPayment InvestmentPaymentRepo;
//        public InvestmentPaymentController(IInvestmentPayment _InvestmentPaymentRepo)
//        {
//            InvestmentPaymentRepo = _InvestmentPaymentRepo;
//        }

//        [NonAction]
//        public Int64 GetSessionUserId()
//        {
//            if (HttpContext.Session.GetString("UserID") != null)
//            {
//                return Convert.ToInt64(HttpContext.Session.GetString("UserID"));
//            }
//            return 0;
//        }

//        public IActionResult Index()
//        {
//            return View();
//        }

//        [HttpGet]
//        public IActionResult ViewDetails(Int64 id)
//        {
//            var rec = this.IVRequestRepo.GetInvestmentByRequestID(id);
//            return View(rec);
//        }

//        [HttpPost]
//        public IActionResult ViewDetails(AcceptInvestmentVM rec)
//        {
//            if (ModelState.IsValid)
//            {
//                return RedirectToAction("Index","InvestmentPayment");
//            }
//            return View(rec);
//        }
//    }
//}
