using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repository;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        IState SRepo;
        ICity CityRepo;
        ICategory CategoryRepo;
        ISubCategory SubCategoryRepo;
        IRisk RiskRepo;
        IIdea IdeaRepo;
        IIVRequest IVRequestRepo;
        IBudget BudgetRepo;
        IQuery QueryRepo;
        public HomeController(IState _SRepo,ICity _CityRepo, ISubCategory _SubCategoryRepo, IRisk _RiskRepo, ICategory _CategoryRepo, IIdea _IdeaRepo, IIVRequest _IVRequestRepo, IBudget _BudgetRepo,IQuery _QueryRepo)
        {
            SRepo = _SRepo;
            CityRepo = _CityRepo;
            SubCategoryRepo = _SubCategoryRepo;
            RiskRepo = _RiskRepo;
            CategoryRepo = _CategoryRepo;
            IdeaRepo = _IdeaRepo;
            IVRequestRepo = _IVRequestRepo;
            BudgetRepo = _BudgetRepo;
            QueryRepo = _QueryRepo;
        }

        [NonAction]
        public Int64 GetInvestorSessionID()
        {
            return Convert.ToInt64(HttpContext.Session.GetString("InvestorID"));
        }

        [NonAction]
        public Int64 GetUserSessionID()
        {
            return Convert.ToInt64(HttpContext.Session.GetString("UserID"));
        }

        public IActionResult Index()
        {
            ViewBag.CategoryID = new SelectList(this.CategoryRepo.GetAll(), "CategoryID", "CategoryName");
            ViewBag.SubCategoryID = new SelectList(this.SubCategoryRepo.GetAll(), "SubCategoryID", "SubCategoryName");
            return View();
        }

        [HttpGet]
        public IActionResult ViewDetails(Int64 id )
        {
            ViewBag.CategoryID = new SelectList(this.CategoryRepo.GetAll(), "CategoryID", "CategoryName");
            ViewBag.SubCategoryID = new SelectList(this.SubCategoryRepo.GetAll(), "SubCategoryID", "SubCategoryName");
            var getRecord = this.IdeaRepo.GetAll().Where(p => p.IdeaID == id).Select(p => p.IdeaName).FirstOrDefault();
            ViewBag.IdeaID = id;
            ViewBag.IdeaName = getRecord;
            return View();
        }

        public IActionResult GetStatesJson(Int64 id)
        {
            var rec = this.SRepo.GetStatesByCountryId(id);
            return Json(rec.ToList());
        }

        public IActionResult GetCitiesJson(Int64 id)
        {
            var rec = this.CityRepo.GetCitiesByStateId(id);
            return Json(rec.ToList());
        }

        public IActionResult GetSubCategories(Int64 id)
        {
            var rec = this.SubCategoryRepo.GetSubCategoriesByCategoryId(id);
            return Json(rec.ToList());
        }

        public IActionResult GetIdeas(Int64 IdeaID)
        {
            var rec = this.RiskRepo.GetIdeasByIdeaId(IdeaID);
            return Json(rec.ToList());
        }

        public IActionResult SearchIdea(Int64 CategoryID, Int64 SubCategoryID)
        {
           if(CategoryID != 0 && SubCategoryID != 0)
           {
                ViewBag.CategoryID = new SelectList(this.CategoryRepo.GetAll(), "CategoryID", "CategoryName");
                ViewBag.SubCategoryID = new SelectList(this.SubCategoryRepo.GetAll(), "SubCategoryID", "SubCategoryName");
                var records = this.IdeaRepo.GetAll().Where(p => p.SubCategoryID == SubCategoryID && p.SubCategory.CategoryID == CategoryID);
                ViewBag.records = records.ToList();
                return View("Index");
           }
           else
           {
                ViewBag.CategoryID = new SelectList(this.CategoryRepo.GetAll(), "CategoryID", "CategoryName");
                ViewBag.SubCategoryID = new SelectList(this.SubCategoryRepo.GetAll(), "SubCategoryID", "SubCategoryName");
                var records = this.IdeaRepo.GetAll();
                ViewBag.records = records;
                return View("Index");
           }
        }

        public IActionResult MakeRequest(Int64 id)
        {
            Int64 InvID = GetInvestorSessionID();
            if (InvID != 0)
            {
                return View();
            }
            else
            {
                HttpContext.Session.SetString("MakeRequestStatus","True");
                return RedirectToAction("SignIn", "ManageInvestors");
            }

        }

        [HttpPost]
        public IActionResult MakeRequest(IVRequest rec)
        {
            if (ModelState.IsValid)
            {
                this.IVRequestRepo.Add(rec);
                ViewBag.requestMessage = "Your Investment Request has been sent Successfully !";
                return View("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult AskQuery()
        {
            ViewBag.IdeaID = new SelectList(this.IdeaRepo.GetAll(), "IdeaID", "IdeaName");
            Int64 InvID = GetInvestorSessionID();
            if (InvID != 0)
            {
                return View();
            }
            else
            {
                HttpContext.Session.SetString("AskQueryStatus", "True");
                return RedirectToAction("SignIn", "ManageInvestors");
            }
        }

        [HttpPost]
        public IActionResult AskQuery(Query rec)
        {
            if (ModelState.IsValid)
            {
                rec.QueryDate = DateTime.Now;
                //this.QueryRepo.Add(rec);
                ViewBag.requestMessage = "Your Query has been sent Successfully !";
                return View("Index");
            }
            return View(rec);
        }

        [HttpGet]
        public IActionResult SignOut()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }


        public IActionResult Dashboard()
        {
            Int64 UserID = GetUserSessionID();
            Int64 InvID = GetInvestorSessionID();
            if(UserID != 0)
            {
                return RedirectToAction("Index","UserHome",new {area ="UserArea"});
            }
            else if(InvID != 0)
            {
                return RedirectToAction("Index","InvestorHome",new { area = "InvestorArea"});
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

    }
}
