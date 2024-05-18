using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Repository;

namespace Web.ViewComponents
{
    public class InvestorNewQueriesVC : ViewComponent
    {
        IQuery QueryRepo;
        public InvestorNewQueriesVC(IQuery _QueryRepo)
        {
            QueryRepo = _QueryRepo;
        }

        public IViewComponentResult Invoke(Int64 id)
        {
            Int64 InvestorID = Convert.ToInt64(HttpContext.Session.GetString("InvestorID"));
            var v = this.QueryRepo.GetAllPendingQueriesByInvestorID(InvestorID);
            return View(v.ToList()); 
        }
    }
}