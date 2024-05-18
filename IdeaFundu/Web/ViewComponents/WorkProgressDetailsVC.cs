using Microsoft.AspNetCore.Mvc;
using Repository;

namespace Web.ViewComponents
{
    public class WorkProgressDetailsVC:ViewComponent
    {
        IWorkProgress WorkProgressRepo;
        public WorkProgressDetailsVC(IWorkProgress _WorkProgressRepo)
        {
            WorkProgressRepo = _WorkProgressRepo;
        }
        public IViewComponentResult Invoke(Int64 id)
        {
            var v = this.WorkProgressRepo.GetAll().Where(p=>p.IdeaID == id);
            return View(v.ToList());
        }
    }
}
