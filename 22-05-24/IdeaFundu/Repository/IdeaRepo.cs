using Core;
using Infra;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Repository.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class IdeaRepo : GenericRepo<Idea>, IIdea
    {
        CompanyContext cc;
        public IdeaRepo(CompanyContext cc) : base(cc)
        {
            this.cc = cc;
        }

        public void AddRecord(IdeaBudgetVM rec, string photoFilePath)
        {
            Idea idea = new Idea();
            idea.IdeaName = rec.IdeaName;
            idea.SubCategoryID = rec.SubCategoryID;
            idea.IdeaDescription = rec.IdeaDescription;
            idea.IdeaStatus = true;
            idea.PhotoFilePath = photoFilePath;
            idea.Budget = new Budget();
            idea.Budget.BudgetAmount = rec.BudgetAmount;
            idea.Budget.MaximumInvestmentLimit = rec.MaximumInvestmentLimit;
            idea.Budget.MinimumInvestmentLimit = rec.MinimumInvestmentLimit;
            idea.UserID = rec.UserID;
            this.cc.Ideas.Add(idea);
            this.cc.SaveChanges();
        }

        public void DeleteRecord(long id) 
        {
            var budgetRecord = this.cc.Budgets.Where(p => p.IdeaID == id);

            foreach(var temp in budgetRecord)
            {
                this.cc.Budgets.Remove(temp);
            }
            var ideaRecord = this.cc.Ideas.Find(id);

            this.cc.Ideas.Remove(ideaRecord);
            this.cc.SaveChanges();
        }

        public void EditRecord(Idea rec, string photoFilePath)
        {
            var ideaRecord = this.cc.Ideas.Find(rec.IdeaID);
            ideaRecord.IdeaName = rec.IdeaName;
            ideaRecord.IdeaDescription = rec.IdeaDescription;
            ideaRecord.PhotoFilePath = photoFilePath;
            ideaRecord.SubCategoryID = rec.SubCategoryID;
            ideaRecord.UserID = rec.UserID;
            ideaRecord.Budget.BudgetAmount = rec.Budget.BudgetAmount;
            ideaRecord.Budget.MaximumInvestmentLimit = rec.Budget.MaximumInvestmentLimit;
            ideaRecord.Budget.MinimumInvestmentLimit = rec.Budget.MinimumInvestmentLimit;
            this.cc.SaveChanges();
        }

        public List<Idea> GetAllByUserID(long userid)
        {
            return this.cc.Ideas.Where(p => p.UserID == userid).ToList();
        }

        public List<TotalInvestmentDetailsVM> GetIdeaWiseReport(long IdeaID)
        {
            var v = from t1 in this.cc.Investors.ToList()
                    join t2 in this.cc.IVRequests.ToList()
                    on t1.InvestorID equals t2.InvestorID
                    join t3 in this.cc.AcceptInvestments.ToList()
                    on t2.IVRequestID equals t3.IVRequestID
                    join t4 in this.cc.InvestmentPayments.ToList()
                    on t3.AcceptIVID equals t4.AcceptIVID
                    where t2.IdeaID == IdeaID
                    group t4 by new
                    {
                        t1.FullName,
                        t1.InvestorMobile,
                        t1.InvestorEmail,
                        t1.InvestorAddress,
                        t2.Idea.IdeaName,
                        t1.City.CityName,
                        t4.PaymentAmount,
                        t4.PaymentDate,
                        t4.PaymentMode

                    } into g
                    select new TotalInvestmentDetailsVM
                    {
                        FullName = g.Key.FullName,
                        InvestorMobile = g.Key.InvestorMobile,
                        InvestorEmail = g.Key.InvestorEmail,
                        InvestorAddress = g.Key.InvestorAddress,
                        CityName = g.Key.CityName,
                        PaymentAmount = g.Key.PaymentAmount,
                        PaymentDate = g.Key.PaymentDate,
                        PaymentMode = g.Key.PaymentMode,
                        TotalInvAmount = g.Sum(p => p.PaymentAmount),
                        IdeaName = g.Key.IdeaName
                    };

            return v.ToList();
        }
    }
}
