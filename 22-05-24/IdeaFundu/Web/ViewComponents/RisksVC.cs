using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Repository;

namespace Web.ViewComponents
{
    public class RisksVC : ViewComponent
    {
        IRisk IdeaRiskRepo;
        public RisksVC(IRisk _IdeaRiskRepo)
        {
            IdeaRiskRepo = _IdeaRiskRepo;
        }

        public IViewComponentResult Invoke(Int64 id)
        {
            var v = from t in this.IdeaRiskRepo.GetAll().Where(p => p.IdeaID == id)
                    select t;
            return View(v.ToList());
        }
    }
}
