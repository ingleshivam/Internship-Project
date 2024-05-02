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
    //[UserAuthroization]
    public class MemberController : Controller
    {
        IIdea IdeaRepo;
        IMember MemberRepo;    
        public MemberController(IIdea _IdeaRepo, IMember _MemberRepo)
        {
            IdeaRepo = _IdeaRepo;
            MemberRepo = _MemberRepo;
        }
        public IActionResult Index()
        {
            return View(this.MemberRepo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.IdeaID = new SelectList(this.IdeaRepo.GetAll(), "IdeaID", "IdeaName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(MemberVM rec)
        {
            if (ModelState.IsValid)
            {
                for (int i=0; i < rec.MemberName.Count(); i++)
                {
                    Member member = new Member();
                    member.MemberName = rec.MemberName[i];
                    member.MemberRole = rec.MemberRole[i];
                    member.ShortProfileDesc = rec.ShortProfileDesc[i];
                    member.IdeaID = rec.IdeaID[i];
                    this.MemberRepo.Add(member);
                }
                return RedirectToAction("Index");
            }
            return View(rec);
        }


        //[HttpGet]
        //public IActionResult Edit(Int64 id)
        //{
        //    //var rec = this.MemberRepo.GetById(id);
        //    var rec = from t in this.MemberRepo.GetAll()
        //              where t.MemberID == id
        //              select new MemberVM
        //              {
        //                  MemberID = t.MemberID,
        //                  MemberName =  t.MemberName,
        //                  MemberRole = t.MemberRole,
        //                  ShortProfileDesc = t.ShortProfileDesc,
        //                  IdeaID = t.IdeaID
        //              };
        //    ViewBag.IdeaID = new SelectList(this.IdeaRepo.GetAll(), "IdeaID", "IdeaName", rec.IdeaID);
        //    return View(rec);
        //}


        [HttpPost]
        public IActionResult Edit(Member rec)
        {
            ViewBag.IdeaID = new SelectList(this.IdeaRepo.GetAll(), "IdeaID", "IdeaName");
            if (ModelState.IsValid)
            {
                this.MemberRepo.Edit(rec);
                return RedirectToAction("Create");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.MemberRepo.Delete(id);
            return RedirectToAction("Create");
        }
    }
}
