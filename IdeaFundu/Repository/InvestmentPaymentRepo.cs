using Core;
using Infra;
using Infra.Migrations;
using Repository.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class InvestmentPaymentRepo : GenericRepo<InvestmentPayment>, IInvestmentPayment
    {
        CompanyContext cc;
        public InvestmentPaymentRepo(CompanyContext cc) : base(cc)
        {
            this.cc = cc;
        }

        public void AddRecord(InvestmentPayment rec)
        {
            //this.cc.InvestmentPayments.Add(rc);
            this.cc.SaveChanges();
        }

        public InvestmentPayment GetInvestmentPaymentDetails(AcceptInvestmentVM rec)
        {
            InvestmentPayment InvPayment = new InvestmentPayment();
            InvPayment.PaymentAmount = rec.AmountAccepted;
            InvPayment.PaymentDate = DateTime.Now;
            InvPayment.PaymentMode = (int)rec.PaymentMode;
            InvPayment.AcceptIVID = rec.AcceptIVID;
            return InvPayment;
        }

        public IEnumerable<IdeaInvestmentTotalVM> GetAllIdeasTotal(Int64 UserID)
        {
            var record = from t in this.cc.Ideas.ToList()
                         join t1 in this.cc.IVRequests.ToList()
                         on t.IdeaID equals t1.IdeaID
                         join t2 in this.cc.AcceptInvestments.ToList()
                         on t1.IVRequestID equals t2.IVRequestID
                         join t3 in this.cc.InvestmentPayments.ToList()
                         on t2.AcceptIVID equals t3.AcceptIVID
                         where t.UserID == UserID
                         group t3 by new
                         {
                             t.IdeaID,
                             t.IdeaName
                         } into g
                         select new IdeaInvestmentTotalVM
                         {
                             IdeaID = g.Key.IdeaID,
                             IdeaName = g.Key.IdeaName,
                             TotalAmount = g.Sum(p =>p.PaymentAmount)
                         };

            return record.ToList();
        }

        public IEnumerable<InvestmentPaymentsVM> GetAllIdeasById(Int64 UserID,long IdeaID)
        {
            var record = from t in this.cc.Ideas.ToList()
                         join t1 in this.cc.IVRequests.ToList()
                         on t.IdeaID equals t1.IdeaID
                         join t2 in this.cc.AcceptInvestments.ToList()
                         on t1.IVRequestID equals t2.IVRequestID
                         join t3 in this.cc.InvestmentPayments.ToList()
                         on t2.AcceptIVID equals t3.AcceptIVID
                         where t.UserID == UserID && t.IdeaID == IdeaID
                         group t3 by new
                         {
                             t.IdeaID,
                             t.IdeaName,
                             t3.PaymentDate,
                             t3.PaymentMode,
                             t3.PaymentAmount
                         } into g
                         select new InvestmentPaymentsVM
                         {
                             IdeaID = g.Key.IdeaID,
                             IdeaName = g.Key.IdeaName,
                             PaymentDate = g.Key.PaymentDate,
                             PaymentMode = g.Key.PaymentMode,
                             TotalAmount = g.Key.PaymentAmount
                         };

            return record.ToList();
        }

        public IEnumerable<WorkProgressClosureVM> GetWorkProgressByIdeaId(long IdeaID)
        {
            var findRecord = this.cc.WorkClosures.Where(p => p.IdeaID == IdeaID).FirstOrDefault();
            if (findRecord != null)
            {
                var getWorkClosureRecord = from t in this.cc.WorkClosures
                                           where t.IdeaID == IdeaID
                                           select new WorkProgressClosureVM
                                           {
                                               WorkClosureID = t.WorkClosureID,
                                               ClosureDate = t.ClosureDate,
                                               ClosureStatus = t.ClosureStatus,
                                               WorkStatus = "Closed"
                                           };

                return getWorkClosureRecord;
            }
            else
            {
                var getWorkInProgressRecord = from t in this.cc.WorkProgresses
                                              where t.IdeaID == IdeaID
                                              select new WorkProgressClosureVM
                                              {
                                                  WorkProgressID = t.WorkProgressID,
                                                  StartDate = t.StartDate,
                                                  ExpectedCompletionDate = t.ExpectedCompletionDate,
                                                  CurrentStatus = t.CurrentStatus,
                                                  WorkStatus = "InProgress"
                                              };
                return getWorkInProgressRecord;
            }
        }
    }
}
