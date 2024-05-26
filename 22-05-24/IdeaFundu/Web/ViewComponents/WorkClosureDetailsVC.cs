using Microsoft.AspNetCore.Mvc;
using Repository;

namespace Web.ViewComponents
{
    public class WorkClosureDetailsVC : ViewComponent
    {
        IWorkClosure WorkClosureRepo;
        public WorkClosureDetailsVC(IWorkClosure _WorkClosureRepo)
        {
            WorkClosureRepo = _WorkClosureRepo;
        }

        public IViewComponentResult Invoke(Int64 id)
        {
            var v = this.WorkClosureRepo.GetAll().Where(p => p.IdeaID == id);
            return View(v.ToList());
        }
    }
}
