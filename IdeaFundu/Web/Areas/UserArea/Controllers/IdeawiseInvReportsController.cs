using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repository;
using Web.CustFilter;

namespace Web.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    [UserAuthroization]
    public class IdeawiseInvReportsController : Controller
    {
        IIdea IdeaRepo;
        public IdeawiseInvReportsController(IIdea _IdeaRepo)
        {
            IdeaRepo = _IdeaRepo;
        }
        public IActionResult Index()
        {
            Int64 UserID = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            ViewBag.IdeaID = new SelectList(this.IdeaRepo.GetAllByUserID(UserID),"IdeaID","IdeaName");
            return View();
        }

        public IActionResult IdeaWiseInvReportsAction(Int64 IdeaID)
        {
            Int64 UserID = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            ViewBag.IdeaID = new SelectList(this.IdeaRepo.GetAllByUserID(UserID), "IdeaID", "IdeaName");
            if (ModelState.IsValid)
            {
                var record = this.IdeaRepo.GetIdeaWiseReport(IdeaID).ToList();
                if(record.Count != 0)
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

        public IActionResult printIdeawiseReport(Int64 id)
        {
            var record = this.IdeaRepo.GetIdeaWiseReport(id).ToList();
            return View(record.ToList());
        }
    }
}
