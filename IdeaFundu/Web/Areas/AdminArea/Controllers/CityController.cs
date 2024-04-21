using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NuGet.Protocol.Plugins;
using Repository;
using Web.CustFilter;

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
        public IActionResult Create(City rec)
        {
            ViewBag.CountryID = new SelectList(this.CRepo.GetAll(), "CountryID", "CountryName");
            ViewBag.StateID = new SelectList(this.CityRepo.GetAll(), "StateID", "StateName");
            if (ModelState.IsValid)
            {
                this.CityRepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            ViewBag.CountryID = new SelectList(this.CRepo.GetAll(), "CountryID", "CountryName");
            ViewBag.StateID = new SelectList(this.CityRepo.GetAll(), "StateID", "StateName");
            var rec = this.CityRepo.GetById(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(City rec)
        {
            ViewBag.CountryID = new SelectList(this.CRepo.GetAll(), "CountryID", "CountryName");
            ViewBag.StateID = new SelectList(this.CityRepo.GetAll(), "StateID", "StateName");
            if (ModelState.IsValid)
            {
                this.CityRepo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.CityRepo.Delete(id);
            return RedirectToAction("Index");
        }


    }
}
