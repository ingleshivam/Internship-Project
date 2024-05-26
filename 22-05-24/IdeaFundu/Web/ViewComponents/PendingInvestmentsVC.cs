using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Repository;

namespace Web.ViewComponents
{
    public class PendingInvestmentsVC : ViewComponent
    {
        IIVRequest IVRequestRepo;
        public PendingInvestmentsVC(IIVRequest _IVRequestRepo)
        {
            IVRequestRepo = _IVRequestRepo;
        }

        public IViewComponentResult Invoke(Int64 id)
        {
            Int64 UserID = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            var v = this.IVRequestRepo.GetAllPendingInvestments(UserID);
            return View(v.ToList());
        }
    }
}