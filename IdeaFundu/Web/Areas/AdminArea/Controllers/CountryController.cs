using Core;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol.Plugins;
using Repository;
using Repository.ViewModels;
using Web.CustFilter;

namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [AdminAuthroization]
    public class CountryController : Controller
    {
        ICountry CRepo;
        public CountryController(ICountry _CRepo)
        {
            CRepo = _CRepo;
        }

        public IActionResult Index()
        {
            return View(this.CRepo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Country rec)
        {
            if (ModelState.IsValid)
            {
                var record = this.CRepo.GetByName(rec.CountryName);
                if (record)
                {
                    TempData["CountryAlreadyExists"] = "This Country Already Exists !";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["CountryAddedSuccessfully"] = "Country Added Successfully !";
                    this.CRepo.Add(rec);
                }
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.CRepo.GetById(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(Country rec)
        {
            if (ModelState.IsValid)
            {
                this.CRepo.Edit(rec);
                TempData["CountryUpdated"] = "Country Updated Successfully !";
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.CRepo.Delete(id);
            TempData["CountryDeleted"] = "Country Deleted Successfully !";
            return RedirectToAction("Index");
        }

    }
}
