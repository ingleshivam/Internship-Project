using Core;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace Web.ViewComponents
{
    public class RiskListVC:ViewComponent
    {
        IRisk RiskRepo;
        public RiskListVC(IRisk _RiskRepo)
        {
            RiskRepo = _RiskRepo;
        }

        public IViewComponentResult Invoke()
        {
            var rec = this.RiskRepo.GetAll();
            return View(rec);
        }
    }
}
