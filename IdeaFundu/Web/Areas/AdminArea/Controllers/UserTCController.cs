using Core;
using Microsoft.AspNetCore.Mvc;
using Repository;
using Web.CustFilter;

namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [AdminAuthroization]
    public class UserTCController : Controller
    {
        IUserTC UserTcRepo;
        public UserTCController ( IUserTC _UserTcRepo)
        {
            UserTcRepo = _UserTcRepo;
        }
        public IActionResult Index()
        {
            return View(this.UserTcRepo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserTC rec)
        {
            if (ModelState.IsValid)
            {
                var record = this.UserTcRepo.GetByName(rec.UserTCTitle);
                if (record)
                {
                    TempData["UserTCAlreadyExists"] = "Terms and Condition Already Exists !";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["UserTCAddedSuccessfully"] = "Terms and Condition Added Successfully !";
                    this.UserTcRepo.Add(rec);
                }
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.UserTcRepo.GetById(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(UserTC rec)
        {
            if (ModelState.IsValid)
            {
                this.UserTcRepo.Edit(rec);
                TempData["UserTCUpdated"] = "Terms and Condition Updated Successfully !";
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.UserTcRepo.Delete(id);
            TempData["UserTCDeleted"] = "Terms and Condition Deleted Successfully !";
            return RedirectToAction("Index");
        }
    }
}
