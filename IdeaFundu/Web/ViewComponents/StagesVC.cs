using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Repository;

namespace Web.ViewComponents
{
    public class StagesVC : ViewComponent
    {
        IStages StagesRepo;
        public StagesVC(IStages _StagesRepo)
        {
            StagesRepo = _StagesRepo;
        }

        public IViewComponentResult Invoke(Int64 id)
        {
            var v = from t in this.StagesRepo.GetAll().Where(p => p.IdeaID == id)
                    select t;
            return View(v.ToList());
        }
    }
}
