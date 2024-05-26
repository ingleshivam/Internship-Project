using Microsoft.AspNetCore.Mvc;
using Repository;

namespace Web.ViewComponents
{
    public class UserTermsVC : ViewComponent
    {
        IUserTC UserTCRepo;
        public UserTermsVC(IUserTC _UserTCRepo)
        {
            UserTCRepo = _UserTCRepo;
        }

        public IViewComponentResult Invoke()
        {
            var fetchTc = this.UserTCRepo.GetAll().ToList();
            return View(fetchTc.ToList());
        }
    }
}

