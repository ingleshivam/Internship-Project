using Microsoft.AspNetCore.Mvc;
using Repository;
using Web.CustFilter;

namespace Web.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    [UserAuthroization]
    public class AllInvReportsController : Controller
    {
        IInvestmentPayment InvestmentPaymentRepo;
        public AllInvReportsController(IInvestmentPayment _InvestmentPaymentRepo)
        {
            InvestmentPaymentRepo = _InvestmentPaymentRepo;
        }
        public IActionResult Index()
        {
            Int64 UserID = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            var record = this.InvestmentPaymentRepo.GetAllIdeasTotal(UserID);
            return View(record.ToList());
        }

        public IActionResult printAllInvReport(Int64 id)
        {
            Int64 UserID = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            var record = this.InvestmentPaymentRepo.GetAllIdeasTotal(UserID);
            return View(record.ToList());
        }
    }
}
