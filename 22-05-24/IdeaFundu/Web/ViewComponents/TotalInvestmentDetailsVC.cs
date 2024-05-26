using Infra.Migrations;
using Microsoft.AspNetCore.Mvc;
using Repository;
using Repository.ViewModels;

namespace Web.ViewComponents
{
    public class TotalInvestmentDetailsVC : ViewComponent
    {
        IInvestor InvestorRepo;
        IIVRequest InvestmentRequestRepo;
        IInvestmentPayment InvestmentPaymentRepo;
        IAcceptInvestment AcceptInvestmentRepo;
        IIdea IdeaRepo;

        public TotalInvestmentDetailsVC(IInvestor _InvestorRepo, IIVRequest _InvestmentRequsetRepo, IInvestmentPayment _InvestmentPaymentRepo, IAcceptInvestment _AcceptInvestmentRepo,IIdea _IdeaRepo)
        {
            InvestorRepo = _InvestorRepo;
            InvestmentRequestRepo = _InvestmentRequsetRepo;
            InvestmentPaymentRepo = _InvestmentPaymentRepo;
            AcceptInvestmentRepo = _AcceptInvestmentRepo;
            IdeaRepo = _IdeaRepo;
        }
        public IViewComponentResult Invoke(Int64 id)
        {
            var v = from t1 in this.InvestorRepo.GetAllUsers()
                    join t2 in this.InvestmentRequestRepo.GetAll()
                    on t1.InvestorID equals t2.InvestorID
                    join t3 in this.AcceptInvestmentRepo.GetAll()
                    on t2.IVRequestID equals t3.IVRequestID                                          
                    join t4 in this.InvestmentPaymentRepo.GetAll()
                    on t3.AcceptIVID equals t4.AcceptIVID
                    where t2.IdeaID == id
                    group t4 by new
                    {
                        t1.FullName,
                        t1.InvestorMobile,
                        t1.InvestorEmail,
                        t1.InvestorAddress,
                        t1.City.CityName,
                        t4.PaymentAmount,
                        t4.PaymentDate,
                        t4.PaymentMode

                    } into g
                    select new TotalInvestmentDetailsVM
                    {
                        FullName = g.Key.FullName,
                        InvestorMobile=g.Key.InvestorMobile,
                        InvestorEmail = g.Key.InvestorEmail,
                        InvestorAddress = g.Key.InvestorAddress,
                        CityName = g.Key.CityName,
                        PaymentAmount = g.Key.PaymentAmount,
                        PaymentDate = g.Key.PaymentDate,
                        PaymentMode = g.Key.PaymentMode,
                        TotalInvAmount = g.Sum(p=>p.PaymentAmount)
                    };

            return View(v.ToList());
        }
    }
}
