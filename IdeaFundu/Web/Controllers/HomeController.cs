using Microsoft.AspNetCore.Mvc;
using Repository;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        IState SRepo;
        ICity CityRepo;
        ISubCategory SubCategoryRepo;
        IRisk RiskRepo;
        public HomeController(IState _SRepo,ICity _CityRepo, ISubCategory _SubCategoryRepo,IRisk _RiskRepo)
        {
            SRepo = _SRepo;
            CityRepo = _CityRepo;
            SubCategoryRepo = _SubCategoryRepo;
            RiskRepo = _RiskRepo;
        }
        public IActionResult Index()
        {
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

        
    }
}
