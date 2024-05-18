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
            Int64 GetSessionUserId = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            var rec = this.RiskRepo.GetAllByUserID(GetSessionUserId);
            return View(rec);
        }
    }
}
