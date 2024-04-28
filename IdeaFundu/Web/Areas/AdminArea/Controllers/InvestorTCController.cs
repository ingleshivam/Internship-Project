﻿using Core;
using Microsoft.AspNetCore.Mvc;
using Repository;
using Web.CustFilter;

namespace Web.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    //[AdminAuthroization]
    public class InvestorTCController : Controller
    {
        IInvestorTC InvestorTcRepo;
        public InvestorTCController ( IInvestorTC _InvestorTcRepo)
        {
            InvestorTcRepo = _InvestorTcRepo;
        }
        public IActionResult Index()
        {
            return View(this.InvestorTcRepo.GetAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(InvestorTC rec)
        {
            if (ModelState.IsValid)
            {
                this.InvestorTcRepo.Add(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.InvestorTcRepo.GetById(id);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(InvestorTC rec)
        {
            if (ModelState.IsValid)
            {
                this.InvestorTcRepo.Edit(rec);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            this.InvestorTcRepo.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
