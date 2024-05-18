using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Repository;

namespace Web.ViewComponents
{
    public class ShowNewInvestmentsVC : ViewComponent
    {
        IIVRequest IVRequestRepo;
        public ShowNewInvestmentsVC(IIVRequest _IVRequestRepo)
        {
            IVRequestRepo = _IVRequestRepo;
        }

        public IViewComponentResult Invoke(Int64 id)
        {
            var v = this.IVRequestRepo.GetAllPendingInvestmentsByInvestorID(id);
            return View(v.ToList());
        }
    }
}
