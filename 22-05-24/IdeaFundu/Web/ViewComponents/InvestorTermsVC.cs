using Microsoft.AspNetCore.Mvc;
using Repository;

namespace Web.ViewComponents
{
    public class InvestorTermsVC : ViewComponent
    {
        IInvestorTC InvestorTCRepo;
        public InvestorTermsVC(IInvestorTC _InvestorTCRepo)
        {
            InvestorTCRepo = _InvestorTCRepo;
        }

        public IViewComponentResult Invoke()
        {
            var fetchTc = this.InvestorTCRepo.GetAll();
            return View(fetchTc.ToList());
        }
    }
}

