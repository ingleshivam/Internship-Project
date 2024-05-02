using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repository;
using Web.CustFilter;
using Repository.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Web.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    [UserAuthroization]
    public class IdeaController : Controller
    {
        IIdea IdeaRepo;
        ICategory CategoryRepo;
        ISubCategory SubCategoryRepo;
        IBudget BudgetRepo;
        public IdeaController(IIdea _IdeaRepo, ICategory _CategoryRepo, ISubCategory _SubCategoryRepo, IBudget _BudgetRepo)
        {
            IdeaRepo = _IdeaRepo;
            CategoryRepo = _CategoryRepo;
            SubCategoryRepo = _SubCategoryRepo;
            BudgetRepo = _BudgetRepo;
        }

        public IActionResult Index()
        {
            Int64 GetSessionUserId = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            //var IdeaBudgetList = from t in this.IdeaRepo.GetAll()
            //                     join t1 in this.BudgetRepo.GetAll()
            //                     on t.IdeaID equals t1.IdeaID
            //                     where t.UserID == GetSessionUserId
            //                     select new IdeaBudgetVM
            //                     {
            //                         IdeaID = t.IdeaID,
            //                         IdeaName = t.IdeaName,
            //                         SubCategoryName = t.SubCategory.SubCategoryName,
            //                         BudgetAmount = t1.BudgetAmount,
            //                         MaximumInvestmentLimit = t1.MaximumInvestmentLimit,
            //                         MinimumInvestmentLimit = t1.MinimumInvestmentLimit
            //                     };

            return View(this.IdeaRepo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(this.CategoryRepo.GetAll(),"CategoryID","CategoryName");
            ViewBag.SubCategoryID = new SelectList(this.SubCategoryRepo.GetAll(),"SubCategoryID","SubCategoryName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(IdeaBudgetVM rec)
        {
            ViewBag.CategoryID = new SelectList(this.CategoryRepo.GetAll(), "CategoryID", "CategoryName");
            ViewBag.SubCategoryID = new SelectList(this.SubCategoryRepo.GetAll(), "SubCategoryID", "SubCategoryName");
            if (ModelState.IsValid)
            {
                Idea idea = new Idea();
                idea.IdeaName = rec.IdeaName;
                idea.SubCategoryID = rec.SubCategoryID;
                idea.Budget = new Budget();
                idea.Budget.BudgetAmount = rec.BudgetAmount;
                idea.Budget.MaximumInvestmentLimit = rec.MaximumInvestmentLimit;
                idea.Budget.MinimumInvestmentLimit = rec.MinimumInvestmentLimit;
                idea.UserID = rec.UserID;
                this.IdeaRepo.Add(idea);
                //this.IdeaRepo.AddRecords(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.IdeaRepo.GetById(id);
            ViewBag.CategoryID = new SelectList(this.CategoryRepo.GetAll(), "CategoryID", "CategoryName",rec.SubCategory.CategoryID);
            ViewBag.SubCategoryID = new SelectList(this.SubCategoryRepo.GetAll(), "SubCategoryID", "SubCategoryName",rec.SubCategoryID);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(Idea rec)
        {
            ViewBag.CategoryID = new SelectList(this.CategoryRepo.GetAll(), "CategoryID", "CategoryName");
            ViewBag.SubCategoryID = new SelectList(this.SubCategoryRepo.GetAll(), "SubCategoryID", "SubCategoryName");
            if (ModelState.IsValid)
            {
                //this.IdeaRepo.Edit(rec);
                this.IdeaRepo.DeleteRecord(rec.IdeaID);
                this.IdeaRepo.EditRecord(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Details(Int64 id)
        {
            var fetchRecord = this.IdeaRepo.GetById(id);
            return View(fetchRecord);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            //this.IdeaRepo.Delete(id);
            this.IdeaRepo.DeleteRecord(id);
            return RedirectToAction("Index");
        }
    }
}
