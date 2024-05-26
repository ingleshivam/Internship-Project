using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NuGet.Protocol.Plugins;
using Repository;
using Repository.ViewModels;
using Web.CustFilter;

namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [AdminAuthroization]
    public class StateController : Controller
    {
        IState SRepo;
        ICountry CRepo;
        public StateController(IState _SRepo,ICountry _CRepo)
        {
            SRepo = _SRepo;
            CRepo = _CRepo;
        }

        public IActionResult Index()
        {
            return View(this.SRepo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.CountryID = new SelectList(this.CRepo.GetAll(),"CountryID","CountryName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(State rec)
        {
            ViewBag.CountryID = new SelectList(this.CRepo.GetAll(), "CountryID", "CountryName");
            if (ModelState.IsValid)
            {
                var record = this.SRepo.GetByName(rec.StateName);
                if (record)
                {
                    TempData["StateAlreadyExists"] = "This State Already Exists !";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["StateAddedSuccessfully"] = "State Added Successfully !";
                    this.SRepo.Add(rec);
                }
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            ViewBag.CountryID = new SelectList(this.CRepo.GetAll(), "CountryID", "CountryName");
            var rec = this.SRepo.GetById(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(State rec)
        {
            ViewBag.CountryID = new SelectList(this.CRepo.GetAll(), "CountryID", "CountryName");
            if (ModelState.IsValid)
            {
                this.SRepo.Edit(rec);
                TempData["StateUpdated"] = "State Updated Successfully !";
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.SRepo.Delete(id);
            TempData["StateDeleted"] = "State Deleted Successfully !";
            return RedirectToAction("Index");
        }

    }
}
