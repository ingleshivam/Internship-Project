using Core;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace Web.ViewComponents
{
    public class EditRiskListVC:ViewComponent
    {
        IRisk RiskRepo;
        public EditRiskListVC(IRisk _RiskRepo)
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
