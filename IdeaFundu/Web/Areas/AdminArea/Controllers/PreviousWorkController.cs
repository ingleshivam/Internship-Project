using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repository;
using Repository.ViewModels;
using Web.CustFilter;

namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    //[AdminAuthroization]
    public class PreviousWorkController : Controller
    {
        IUser UserRepo;
        IPreviousWork PreviousWorkRepo;
        public PreviousWorkController(IPreviousWork _PreviousWorkRepo, IUser _UserRepo)
        {
            PreviousWorkRepo = _PreviousWorkRepo;
            UserRepo = _UserRepo;
        }
        public IActionResult Index()
        {
            return View(this.PreviousWorkRepo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.UserID = new SelectList(this.UserRepo.GetAllUsers(), "UserID", "FullName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(MainPreviousWorkVM rec)
        {
           
            if (ModelState.IsValid)
            {
                //foreach(var temp in rec)
                //{
                //   // this.PreviousWorkRepo.Add(temp);
                //}
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.PreviousWorkRepo.GetById(id);
            ViewBag.UserID = new SelectList(this.UserRepo.GetAllUsers(), "UserID", "FullName",rec.UserID);
            return View(rec);
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

        public JsonResult InsertData([FromBody] List<PreviousWorkVM> PreviousWorks)
         {
            //PreviousWork pw = new PreviousWork();
            //foreach(var temp in PreviousWorks)
            //{
            //pw.WorkTitle = temp.WorkTitle;
            //pw.WorkDescription = temp.WorkDescription;
            //pw.Duration = temp.Duration;
            //pw.TentativeBudget = temp.TentativeBudget;
            //pw.UserID = temp.UserID;
            //this.PreviousWorkRepo.AddRecord(PreviousWorks);
            //}

            this.PreviousWorkRepo.AddRecord(PreviousWorks);
            return Json(null);
        }

    }
}
