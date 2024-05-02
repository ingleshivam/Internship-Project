using Core;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata;
using Repository;
using Web.CustFilter;

namespace Web.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    [UserAuthroization]
    public class RiskController : Controller
    {
        IIdea IdeaRepo;
        IRisk RiskRepo;
        public RiskController(IIdea _IdeaRepo,IRisk _RiskRepo)
        {
            IdeaRepo = _IdeaRepo;
            RiskRepo = _RiskRepo;
        }
        public IActionResult Index()
        {
            return View(this.RiskRepo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.IdeaID = new SelectList(this.IdeaRepo.GetAll(), "IdeaID", "IdeaName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(IdeaRisk rec)
        {
            if (ModelState.IsValid)
            {
                this.RiskRepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult AddRisk()
        {
            ViewBag.IdeaID = new SelectList(this.IdeaRepo.GetAll(), "IdeaID", "IdeaName");
            return View();
        }

        [HttpPost]
        public IActionResult AddRisk(IdeaRisk rec)
        {
            ViewBag.IdeaID = new SelectList(this.IdeaRepo.GetAll(), "IdeaID", "IdeaName");
            if (ModelState.IsValid)
            {
                this.RiskRepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.RiskRepo.GetById(id);
            ViewBag.IdeaID = new SelectList(this.IdeaRepo.GetAll(), "IdeaID", "IdeaName",rec.IdeaID);
            return View(rec);
        }


        [HttpPost]
        public IActionResult Edit(IdeaRisk rec)
        {
            ViewBag.IdeaID = new SelectList(this.IdeaRepo.GetAll(), "IdeaID", "IdeaName");
            if (ModelState.IsValid)
            {
                this.RiskRepo.Edit(rec);
                return RedirectToAction("Create");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult EditRisks(Int64 id)
        {
            //var rec = this.RiskRepo.GetById(id);
            var rec = this.RiskRepo.GetIdeasByIdeaId(id);
            ViewBag.IdeaID = new SelectList(this.IdeaRepo.GetAll(), "IdeaID", "IdeaName", rec.Any(p=>p.IdeaID == id));
            return View(rec);
        }

        [HttpPost]                                                     
        public IActionResult EditRisks(IdeaRisk rec)
        {
            ViewBag.IdeaID = new SelectList(this.IdeaRepo.GetAll(), "IdeaID", "IdeaName");
            if (ModelState.IsValid)
            {
                this.RiskRepo.Edit(rec);
                return RedirectToAction("Create");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Details(Int64 id)
        {
            var rec = this.RiskRepo.GetById(id);
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.RiskRepo.Delete(id);
            return RedirectToAction("Create");
        }
    }
}
