using Microsoft.AspNetCore.Mvc;
using Repository;

namespace Web.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    public class InvestmentsController : Controller
    {
        IIdea IdeaRepo;
        IInvestmentPayment InvestmentPaymentRepo;
        IIVRequest InvestmentRequestRepo;
        IAcceptInvestment AcceptInvestmentRepo;
        public InvestmentsController(IIdea _IdeaRepo, IInvestmentPayment _InvestmentPaymentRepo, IIVRequest _InvestmentRequestRepo, IAcceptInvestment _AcceptInvestmentRepo)
        {
            IdeaRepo = _IdeaRepo;
            InvestmentPaymentRepo = _InvestmentPaymentRepo;
            InvestmentRequestRepo = _InvestmentRequestRepo;
            AcceptInvestmentRepo = _AcceptInvestmentRepo;
        }
        public IActionResult Index()
        {
            Int64 UserID = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            var v = this.InvestmentPaymentRepo.GetAllIdeasTotal(UserID);
            return View(v.ToList());
        }

        public IActionResult ViewDetails(Int64 id)
        {
            Int64 UserID = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            var result = this.InvestmentPaymentRepo.GetAllIdeasById(UserID,id);
            return View(result.ToList());
        }

        public IActionResult WorkProgressDetails(Int64 id)
        {
            var result = this.InvestmentPaymentRepo.GetWorkProgressByIdeaId(id);
            if(result.FirstOrDefault().WorkStatus == "Closed")
            {
                ViewBag.WorkClosureStatus = "display:block;";
                return View(result.ToList());
            }
            else
            {
                ViewBag.WorkInProgress = "display:block;";
                return View(result.ToList().OrderByDescending(p => p.WorkProgressID));
            }
        }
    }
}
