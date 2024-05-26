using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Repository;

namespace Web.ViewComponents
{
    public class ShowAcceptedInvestmentsVC : ViewComponent
    {
        IIVRequest IVRequestRepo;
        public ShowAcceptedInvestmentsVC(IIVRequest _IVRequestRepo)
        {
            IVRequestRepo = _IVRequestRepo;
        }

        public IViewComponentResult Invoke(Int64 id)
        {
            var v = this.IVRequestRepo.GetAllAcceptedInvestmentsByInvestorID(id);
            return View(v.ToList());
        }
    }
}
