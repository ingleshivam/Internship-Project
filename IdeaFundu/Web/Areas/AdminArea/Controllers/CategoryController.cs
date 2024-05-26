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
    public class CategoryController : Controller
    {
        ICategory CategoryRepo;
        public CategoryController(ICategory _CategoryRepo)
        {
            CategoryRepo = _CategoryRepo;
        }

        public IActionResult Index()
        {
            return View(this.CategoryRepo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category rec)
        {
            if (ModelState.IsValid)
            {
                var record = this.CategoryRepo.GetByName(rec.CategoryName);
                if (record)
                {
                    TempData["CategoryAlreadyExists"] = "This Category Already Exists !";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["CategoryAddedSuccessfully"] = "Category Added Successfully !";
                    this.CategoryRepo.Add(rec);
                }
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.CategoryRepo.GetById(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(Category rec)
        {
            if (ModelState.IsValid)
            {
                this.CategoryRepo.Edit(rec);
                TempData["CategoryUpdated"] = "Category Updated Successfully !";
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.CategoryRepo.Delete(id);
            TempData["CategoryDeleted"] = "Category Deleted Successfully !";
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
