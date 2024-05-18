using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Repository;

namespace Web.ViewComponents
{
    public class BudgetVC : ViewComponent
    {
        IBudget BudgetRepo;
        public BudgetVC(IBudget _BudgetRepo)
        {
            BudgetRepo = _BudgetRepo;
        }

        public IViewComponentResult Invoke(Int64 id)
        {
            var v = from t in this.BudgetRepo.GetAll()
                    where t.IdeaID == id
                    select t;
            return View(v);
        }
    }
}
