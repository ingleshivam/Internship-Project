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
    public class CityController : Controller
    {
        IState SRepo;
        ICountry CRepo;
        ICity CityRepo;
        public CityController(IState _SRepo,ICountry _CRepo,ICity _CityRepo)
        {
            SRepo = _SRepo;
            CRepo = _CRepo;
            CityRepo = _CityRepo;
        }

        public IActionResult Index()
        {
            return View(this.CityRepo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.StateID = new SelectList(this.SRepo.GetAll(),"StateID","StateName");
            ViewBag.CountryID = new SelectList(this.CRepo.GetAll(),"CountryID","CountryName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(CityVM rec)
        {
            ViewBag.CountryID = new SelectList(this.CRepo.GetAll(), "CountryID", "CountryName");
            ViewBag.StateID = new SelectList(this.SRepo.GetAll(), "StateID", "StateName");
            if (ModelState.IsValid)
            {
                var record = this.CityRepo.GetByName(rec.CityName);
                if (record)
                {
                    TempData["CityAlreadyExists"] = "This City Already Exists !";
                    return RedirectToAction("Index");
                }
                else
                {
                    this.CityRepo.AddRecord(rec);
                    TempData["CityAddedSuccessfully"] = "City Added Successfully !";
                    return RedirectToAction("Index");
                }
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.CityRepo.GetCityById(id);
            ViewBag.CountryID = new SelectList(this.CRepo.GetAll(), "CountryID", "CountryName",rec.CountryID);
            ViewBag.StateID = new SelectList(this.SRepo.GetAll(), "StateID", "StateName",rec.StateID);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(CityVM rec)
        {
            ViewBag.CountryID = new SelectList(this.CRepo.GetAll(), "CountryID", "CountryName");
            ViewBag.StateID = new SelectList(this.SRepo.GetAll(), "StateID", "StateName");
            if (ModelState.IsValid)
            {
                this.CityRepo.EditRecord(rec);
                TempData["CityUpdated"] = "City Updated Successfully !";
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.CityRepo.Delete(id);
            TempData["CityDeleted"] = "City Deleted Successfully !";
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

        public IActionResult GetStatesJson(Int64 id)
        {
            var rec = this.SRepo.GetStatesByCountryId(id);
            return Json(rec.ToList());
        }

    }
}
