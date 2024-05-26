using Microsoft.AspNetCore.Mvc;
using Repository;

namespace Web.ViewComponents
{
    public class ClosedIdeasVC : ViewComponent
    {
        IWorkProgress WorkProgressRepo;
        public ClosedIdeasVC(IWorkProgress _WorkProgressRepo)
        {
            WorkProgressRepo = _WorkProgressRepo;
        }

        public IViewComponentResult Invoke(Int64 id)
        {
            Int64 UserID = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            var v = this.WorkProgressRepo.GetAllWorkClosedIdeas(UserID);
            return View(v.ToList().OrderByDescending(p=>p.ExpectedCompletionDate));
        }   
    }
}
