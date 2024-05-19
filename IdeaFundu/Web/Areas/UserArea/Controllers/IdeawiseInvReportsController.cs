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
            return View();
        }
    }
}
