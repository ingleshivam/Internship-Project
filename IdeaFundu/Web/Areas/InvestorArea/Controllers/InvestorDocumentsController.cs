using Core;
using Humanizer.DateTimeHumanizeStrategy;
using Microsoft.AspNetCore.Mvc;
using Repository;
using System.Security.Cryptography.Pkcs;

namespace Web.Areas.InvestorArea.Controllers
{
    [Area("InvestorArea")]
    //[InvestorAuthroization]
    public class InvestorDocumentsController : Controller
    {
        IInvestorDocument InvestorDocumentRepo;
        public InvestorDocumentsController(IInvestorDocument _InvestorDocumentRepo)
        {
            InvestorDocumentRepo = _InvestorDocumentRepo;
        }
        public IActionResult Index()
        {
            return View(this.InvestorDocumentRepo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(InvestorDocument rec)
        {
            if (ModelState.IsValid)
            {
                var record = this.InvestorDocumentRepo.GetByName(rec.CIN);
                if (record)
                {
                    TempData["InvestorDocumentAlreadyExists"] = "Investor Document Already Exists !";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["InvestorDocumentAddedSuccessfully"] = "Investor Document Added Successfully !";
                    this.InvestorDocumentRepo.Add(rec);
                }
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.InvestorDocumentRepo.Delete((id));
            TempData["InvestorDocumentDeleted"] = "Investor Document Deleted Successfully !";
            return RedirectToAction("Index");
        }
    }
}
