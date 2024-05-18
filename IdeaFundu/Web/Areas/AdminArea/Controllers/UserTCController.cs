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
                this.UserTcRepo.Add(rec);
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
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.UserTcRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
