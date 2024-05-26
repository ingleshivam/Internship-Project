using Core;
using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore.Metadata;
using Repository;
using Repository.ViewModels;
using Web.CustFilter;

namespace Web.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    [UserAuthroization]
    public class StagesController : Controller
    {
        IIdea IdeaRepo;
        IStages StagesRepo;
        public StagesController(IIdea _IdeaRepo, IStages _StagesRepo)
        {
            IdeaRepo = _IdeaRepo;
            StagesRepo = _StagesRepo;
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
            return View(this.StagesRepo.GetAllByUserID(GetSessionUserId()));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.IdeaID = new SelectList(this.IdeaRepo.GetAllByUserID(GetSessionUserId()), "IdeaID", "IdeaName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(StagesVM rec)
        {
            ViewBag.IdeaID = new SelectList(this.IdeaRepo.GetAllByUserID(GetSessionUserId()), "IdeaID", "IdeaName");
            if (ModelState.IsValid)
            {
                for (int i = 0; i < rec.Stagess.StageName.Count(); i++)
                {
                    Stages stage = new Stages();
                    stage.StageName = rec.Stagess.StageName[i];
                    stage.StageDescription = rec.Stagess.StageDescription[i];
                    stage.IdeaID = rec.Stagess.IdeaID[i];
                    this.StagesRepo.Add(stage);
                }
                return RedirectToAction("Index");
            }
            return View(rec);
        }


        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            //var rec = this.MemberRepo.GetById(id);
            var rec = from t in this.StagesRepo.GetAll()
                      where t.StageID == id
                      select new StagesVM
                      {
                          StageID = t.StageID,
                          StageName = t.StageName,
                          StageDescription = t.StageDescription,
                          IdeaID = t.IdeaID
                      };
            ViewBag.IdeaID = new SelectList(this.IdeaRepo.GetAllByUserID(GetSessionUserId()), "IdeaID", "IdeaName");
            return View(rec.FirstOrDefault());
        }


        [HttpPost]
        public IActionResult Edit(Stages rec)
        {
            ViewBag.IdeaID = new SelectList(this.IdeaRepo.GetAllByUserID(GetSessionUserId()), "IdeaID", "IdeaName");
            if (ModelState.IsValid)
            {
                this.StagesRepo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.StagesRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
