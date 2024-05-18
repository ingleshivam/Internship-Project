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
    public class MemberController : Controller
    {
        IIdea IdeaRepo;
        IMember MemberRepo;
        public MemberController(IIdea _IdeaRepo, IMember _MemberRepo)
        {
            IdeaRepo = _IdeaRepo;
            MemberRepo = _MemberRepo;
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
            return View(this.MemberRepo.GetAllByUserID(GetSessionUserId()));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.IdeaID = new SelectList(this.IdeaRepo.GetAllByUserID(GetSessionUserId()), "IdeaID", "IdeaName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(MemberVM rec)
        {
            ViewBag.IdeaID = new SelectList(this.IdeaRepo.GetAllByUserID(GetSessionUserId()), "IdeaID", "IdeaName");
            if (ModelState.IsValid)
            {
                for (int i = 0; i < rec.Members.MemberName.Count(); i++)
                {
                    Member member = new Member();
                    member.MemberName = rec.Members.MemberName[i];
                    member.MemberRole = rec.Members.MemberRole[i];
                    member.ShortProfileDesc = rec.Members.ShortProfileDesc[i];
                    member.IdeaID = rec.Members.IdeaID[i];
                    this.MemberRepo.Add(member);
                }
                return RedirectToAction("Index");
            }
            return View(rec);
        }


        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            //var rec = this.MemberRepo.GetById(id);
            var rec = from t in this.MemberRepo.GetAll()
                      where t.MemberID == id
                      select new MemberVM
                      {
                          MemberID = t.MemberID,
                          MemberName = t.MemberName,
                          MemberRole = t.MemberRole,
                          ShortProfileDesc = t.ShortProfileDesc,
                          IdeaID = t.IdeaID
                      };
            ViewBag.IdeaID = new SelectList(this.IdeaRepo.GetAllByUserID(GetSessionUserId()), "IdeaID", "IdeaName");
            return View(rec.FirstOrDefault());
        }


        [HttpPost]
        public IActionResult Edit(Member rec)
        {
            ViewBag.IdeaID = new SelectList(this.IdeaRepo.GetAllByUserID(GetSessionUserId()), "IdeaID", "IdeaName");
            if (ModelState.IsValid)
            {
                this.MemberRepo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.MemberRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
