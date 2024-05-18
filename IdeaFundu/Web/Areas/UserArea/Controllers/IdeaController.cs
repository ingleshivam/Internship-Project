using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repository;
using Web.CustFilter;
using Repository.ViewModels;
using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace Web.Areas.UserArea.Controllers
{
    [Area("UserArea")]
    [UserAuthroization]
    public class IdeaController : Controller
    {
        IIdea IdeaRepo;
        ICategory CategoryRepo;
        ISubCategory SubCategoryRepo;
        IBudget BudgetRepo;
        IIdeaDocuments IdeaDocumentsRepo;
        IWebHostEnvironment env;
        IDocumentType DocumentTypeRepo;
        IWorkProgress WorkProgressRepo;
        IWorkClosure WorkClosureRepo;
        public IdeaController(IIdea _IdeaRepo, ICategory _CategoryRepo, ISubCategory _SubCategoryRepo, IBudget _BudgetRepo, IWebHostEnvironment env, IIdeaDocuments _IdeaDocumentsRepo, IDocumentType _DocumentTypeRepo, IWorkProgress _WorkProgressRepo, IWorkClosure _WorkClosureRepo)
        {
            IdeaRepo = _IdeaRepo;
            CategoryRepo = _CategoryRepo;
            SubCategoryRepo = _SubCategoryRepo;
            BudgetRepo = _BudgetRepo;
            this.env = env;
            IdeaDocumentsRepo = _IdeaDocumentsRepo;
            DocumentTypeRepo = _DocumentTypeRepo;
            WorkProgressRepo = _WorkProgressRepo;
            WorkClosureRepo = _WorkClosureRepo;
        }
        
        [NonAction]
        public Int64 GetSessionUserId()
        {
            if (HttpContext.Session.GetString("UserID") != null)
            {
                return Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            }
            return 0;
        }

        public IActionResult Index()
        {
            return View(this.IdeaRepo.GetAllByUserID(GetSessionUserId()));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.CategoryID = new SelectList(this.CategoryRepo.GetAll(),"CategoryID","CategoryName");
            ViewBag.SubCategoryID = new SelectList(this.SubCategoryRepo.GetAll(),"SubCategoryID","SubCategoryName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(IdeaBudgetVM rec)
        {
            ViewBag.CategoryID = new SelectList(this.CategoryRepo.GetAll(), "CategoryID", "CategoryName");
            ViewBag.SubCategoryID = new SelectList(this.SubCategoryRepo.GetAll(), "SubCategoryID", "SubCategoryName");
            string photoFilePath = "";
            if (ModelState.IsValid)
            {

                if (rec.ActualFile != null)
                {
                    if (rec.ActualFile.Length > 0)
                    {
                        string filename = rec.ActualFile.FileName;
                        string UpdatedFileName = filename.Replace(" ", "_");
                        string folderpath = Path.Combine(this.env.WebRootPath, "IdeaImages");
                        string uploadpath = Path.Combine(folderpath, UpdatedFileName);
                        FileStream fs = new FileStream(uploadpath, FileMode.Create);
                        rec.ActualFile.CopyTo(fs);
                        string logicalpath = Path.Combine("\\IdeaImages", UpdatedFileName);
                        photoFilePath = logicalpath;
                    }
                }

                this.IdeaRepo.AddRecord(rec,photoFilePath);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Upload(Int64 id)
        {
            ViewBag.IdeaID = id;
            return View();
        }

        [HttpPost]
        public IActionResult Upload(IdeaDocuments rec)
        {
            if (ModelState.IsValid)
            {
                if (rec.ActualFile != null)
                {
                    if (rec.ActualFile.Length > 0)
                    {
                        string filename = rec.ActualFile.FileName;
                        string UpdatedFileName = filename.Replace(" ", "_");
                        var extensions = UpdatedFileName.Split(".");
                        var docType = extensions[1];
                        if(docType == rec.FetchDocumentTypeName)
                        {
                            string folderpath = Path.Combine(this.env.WebRootPath, "Documents");
                            string uploadpath = Path.Combine(folderpath, UpdatedFileName);
                            FileStream fs = new FileStream(uploadpath, FileMode.Create);
                            rec.ActualFile.CopyTo(fs);
                            string logicalpath = Path.Combine("\\Documents", UpdatedFileName);
                            rec.Attachments = logicalpath;
                        }
                    }
                }
                //Int64 userid = Convert.ToInt64(HttpContext.Session.GetString("IdeaID"));
                //rec.Idea.UserID = userid;
                this.IdeaDocumentsRepo.Add(rec);
                return RedirectToAction("Upload");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Edit(Int64 id)
        {
            var rec = this.IdeaRepo.GetById(id);
            ViewBag.CategoryID = new SelectList(this.CategoryRepo.GetAll(), "CategoryID", "CategoryName",rec.SubCategory.CategoryID);
            ViewBag.SubCategoryID = new SelectList(this.SubCategoryRepo.GetAll(), "SubCategoryID", "SubCategoryName",rec.SubCategoryID);
            return View(rec);
        }

        [HttpPost]
        public IActionResult Edit(Idea rec)
        {
            ViewBag.CategoryID = new SelectList(this.CategoryRepo.GetAll(), "CategoryID", "CategoryName");
            ViewBag.SubCategoryID = new SelectList(this.SubCategoryRepo.GetAll(), "SubCategoryID", "SubCategoryName");
            string photoFilePath = "";
            if (ModelState.IsValid)
            {
                if (rec.ActualFile != null)
                {
                    if (rec.ActualFile.Length > 0)
                    {
                        string filename = rec.ActualFile.FileName;
                        string UpdatedFileName = filename.Replace(" ", "_");
                        string folderpath = Path.Combine(this.env.WebRootPath, "IdeaImages");
                        string uploadpath = Path.Combine(folderpath, UpdatedFileName);
                        FileStream fs = new FileStream(uploadpath, FileMode.Create);
                        rec.ActualFile.CopyTo(fs);
                        string logicalpath = Path.Combine("\\IdeaImages", UpdatedFileName);
                        photoFilePath = logicalpath;                        
                    }
                }
                else
                {
                    photoFilePath = rec.PhotoFilePath;
                }

                this.IdeaRepo.EditRecord(rec,photoFilePath);
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult Details(Int64 id)
        {
            var fetchRecord = this.IdeaRepo.GetById(id);
            return View(fetchRecord);
        }

        [HttpGet]
        public IActionResult Delete(Int64 id)
        {
            //this.IdeaRepo.Delete(id);
            this.IdeaRepo.DeleteRecord(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateProgress(Int64 id)
        {
            ViewBag.IdeaID = id;
            return View();
        }

        [HttpPost]
        public IActionResult UpdateProgress(WorkProgress rec)
        {
            if (ModelState.IsValid)
            {
                this.WorkProgressRepo.Add(rec);
                TempData["WorkProgressStatus"] = "Work Progress has been Updated Successfully !";
                return RedirectToAction("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult CloseWork(Int64 id)
        {
            ViewBag.IdeaID = id;
            return View();
        }

        [HttpPost]
        public IActionResult CloseWork(WorkClosure rec)
        {
            this.WorkClosureRepo.Add(rec);
            TempData["WorkClosureStatus"] = "Work Closure has been submitted Successfully !";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult ClosureViewDetails(Int64 id)
        {
            ViewBag.IdeaID = id;
            return View();
        }

        [HttpGet]
        public IActionResult WorkProgress(Int64 id)
        {
            var workProgressResult = this.WorkProgressRepo.GetAll().Where(p=>p.IdeaID == id).OrderBy(p=>p.Remarks).OrderByDescending(p=>p.ExpectedCompletionDate);
            return View(workProgressResult.ToList());
        }

        [HttpGet]
        public IActionResult WorkProgressDetails(Int64 id)
        {
            ViewBag.WorkProgressID = id;
            var v = this.WorkProgressRepo.GetAll().Where(p => p.WorkProgressID == id).FirstOrDefault();
            return View(v);
        }

        [HttpGet]
        public IActionResult WorkProgressEdit(Int64 id)
        {
            var v = this.WorkProgressRepo.GetAll().Where(p=>p.WorkProgressID == id).FirstOrDefault();
            return View(v);
        }

        [HttpPost]
        public IActionResult WorkProgressEdit(WorkProgress rec)
        {
            this.WorkProgressRepo.Edit(rec);
            TempData["WorkProgressUpdate"] = "Work Progress Updated Successfully !";
            return RedirectToAction("Index");
        }
    }
}
