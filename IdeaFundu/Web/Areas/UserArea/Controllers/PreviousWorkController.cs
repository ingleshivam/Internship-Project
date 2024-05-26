using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repository;
using Repository.ViewModels;
using Web.CustFilter;

namespace Web.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    [UserAuthroization]
    public class PreviousWorkController : Controller
    {
        IUser UserRepo;
        IPreviousWork PreviousWorkRepo;
        public PreviousWorkController(IPreviousWork _PreviousWorkRepo, IUser _UserRepo)
        {
            PreviousWorkRepo = _PreviousWorkRepo;
            UserRepo = _UserRepo;
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
            return View(this.PreviousWorkRepo.GetAllByUserID(GetSessionUserId()));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PreviousWorkVM rec)
        {
            Int64 UserID = Convert.ToInt32(HttpContext.Session.GetString("UserID"));
            if (ModelState.IsValid)
            {
                this.PreviousWorkRepo.AddWorkRecord(rec,UserID);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            ViewBag.UserID = new SelectList(this.UserRepo.GetAllUsers(), "UserID", "FullName");
            //var rec = this.MemberRepo.GetById(id);
            if (ModelState.IsValid)
            {
                var rec = this.PreviousWorkRepo.EditWorkRecord(id);
                return View(rec.FirstOrDefault());
            }
            return View();
        }

        [HttpPost]
        public IActionResult Edit(PreviousWork rec)
        {
            if (ModelState.IsValid)
            {
                this.PreviousWorkRepo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.PreviousWorkRepo.Delete(id);
            return RedirectToAction("Index");
        }

        //public JsonResult InsertData(List<PreviousWorkVM> PreviousWorks)
        // {
        //    //PreviousWork pw = new PreviousWork();
        //    //foreach(var temp in PreviousWorks)
        //    //{
        //    //pw.WorkTitle = temp.WorkTitle;
        //    //pw.WorkDescription = temp.WorkDescription;
        //    //pw.Duration = temp.Duration;
        //    //pw.TentativeBudget = temp.TentativeBudget;
        //    //pw.UserID = temp.UserID;
        //    //this.PreviousWorkRepo.AddRecord(PreviousWorks);
        //    //}

        //    this.PreviousWorkRepo.AddRecord(PreviousWorks);
        //    return Json(null);
        //}

    }
}
