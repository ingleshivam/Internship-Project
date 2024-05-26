using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repository;
using Web.CustFilter;
using Repository.ViewModels;

namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [AdminAuthroization]
    public class SubCategoryController : Controller
    {
        ICategory CategoryRepo;
        ISubCategory SubCategoryRepo;
        public SubCategoryController(ICategory _CategoryRepo,ISubCategory _SubCategoryRepo)
        {
            CategoryRepo = _CategoryRepo;
            SubCategoryRepo = _SubCategoryRepo;
        }

        public IActionResult Index()
        {
            return View(this.SubCategoryRepo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(this.CategoryRepo.GetAll(), "CategoryID", "CategoryName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(SubCategory rec)
        {
            ViewBag.CategoryID = new SelectList(this.CategoryRepo.GetAll(), "CategoryID", "CategoryName");
            if (ModelState.IsValid)
            {
                this.SubCategoryRepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.SubCategoryRepo.GetById(id);
            ViewBag.CategoryID = new SelectList(this.CategoryRepo.GetAll(), "CategoryID", "CategoryName",rec.CategoryID);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(SubCategory rec)
        {
            ViewBag.CategoryID = new SelectList(this.CategoryRepo.GetAll(), "CategoryID", "CategoryName");
            if (ModelState.IsValid)
            {
                this.SubCategoryRepo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.SubCategoryRepo.Delete(id);
            return RedirectToAction("Index");
        }

        //public IActionResult SearchByCountry(Int64 CountryID = 0)
        //{
        //    if (CountryID != 0)
        //    {
        //        var v = from t in this.SRepo.GetAll()
        //                where t.CountryID == CountryID
        //                select new StateVM
        //                {
        //                    StateID = t.StateID,
        //                    StateName = t.StateName
        //                };
        //        return Json(v.ToList());
        //    }
        //    return View();
        //}

        //public IActionResult GetStatesJson(Int64 id)
        //{
        //    var rec = this.SRepo.GetStatesByCountryId(id);
        //    return Json(rec.ToList());
        //}

    }
}
