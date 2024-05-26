using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repository;
using Web.CustFilter;

namespace Web.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    [UserAuthroization]
    public class InvestorwiseInvReportsController : Controller
    {
        IInvestor InvestorRepo;
        public InvestorwiseInvReportsController(IInvestor _InvestorRepo)
        {
            InvestorRepo = _InvestorRepo;
        }
        public IActionResult Index()
        {
            Int64 UserID = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            ViewBag.InvestorID = new SelectList(this.InvestorRepo.GetAllInvestorsIdeaWise(UserID),"InvestorID","FullName");
            return View();
        }

        public IActionResult InvestorWiseInvReportsAction(Int64 InvestorID)
        {
            Int64 UserID = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            ViewBag.InvestorID = new SelectList(this.InvestorRepo.GetAllInvestorsIdeaWise(UserID), "InvestorID", "FullName");
            if (ModelState.IsValid)
            {
                var record = this.InvestorRepo.GetInvestorWiseReport(InvestorID,UserID).ToList();
                if (record.Count != 0)
                {
                    return View(record.ToList());
                }
                else
                {
                    TempData["DetailsNotFound"] = "No Investments Details Found";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        public IActionResult printInvestorwiseReport(Int64 id)
        {
            Int64 UserID = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            var record = this.InvestorRepo.GetInvestorWiseReport(id, UserID).ToList();
            return View(record.ToList());
        }
    }
}
