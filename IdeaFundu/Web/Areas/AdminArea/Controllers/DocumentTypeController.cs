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
    public class DocumentTypeController : Controller
    {
        IDocumentType DocumentTypeRepo;
        public DocumentTypeController(IDocumentType _DocumentTypeRepo)
        {
            DocumentTypeRepo = _DocumentTypeRepo;
        }

        public IActionResult Index()
        {
            return View(this.DocumentTypeRepo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DocumentType rec)
        {
            if (ModelState.IsValid)
            {
                this.DocumentTypeRepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.DocumentTypeRepo.GetById(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(DocumentType rec)
        {
            if (ModelState.IsValid)
            {
                this.DocumentTypeRepo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.DocumentTypeRepo.Delete(id);
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
