using Microsoft.AspNetCore.Mvc;
using Repository;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        IState SRepo;
        ICity CityRepo;
        public HomeController(IState _SRepo,ICity _CityRepo)
        {
            SRepo = _SRepo;
            CityRepo = _CityRepo;
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
    }
}
