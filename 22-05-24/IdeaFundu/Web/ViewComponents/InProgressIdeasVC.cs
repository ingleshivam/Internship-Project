using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace Web.ViewComponents
{
    public class InProgressIdeasVC : ViewComponent
    {
        IWorkProgress WorkProgressRepo;
        public InProgressIdeasVC(IWorkProgress _WorkProgressRepo)
        {
            WorkProgressRepo = _WorkProgressRepo;
        }

        public IViewComponentResult Invoke(Int64 id)
        {
            Int64 UserID = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            var v = this.WorkProgressRepo.GetAllWorkInProgressIdeas(UserID);
            return View(v.ToList().OrderByDescending(p=>p.ExpectedCompletionDate));
        }
    }
}
