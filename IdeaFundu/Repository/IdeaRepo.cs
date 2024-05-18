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
            //Clear Budget Record from DB
            var budgetRecord = this.cc.Budgets.Where(p => p.IdeaID == id);

            foreach(var temp in budgetRecord)
            {
                this.cc.Budgets.Remove(temp);
            }
            var ideaRecord = this.cc.Ideas.Find(id);

            this.cc.Ideas.Remove(ideaRecord);
            this.cc.SaveChanges();

            //Multiple Deletion of Records

            //var allRecords = from ideaRisk in this.cc.IdeaRisks
            //                 join member in this.cc.Members
            //                 on ideaRisk.IdeaID equals member.IdeaID
            //                 join stages in this.cc.Stages
            //                 on ideaRisk.IdeaID equals stages.IdeaID
            //                 join budget in this.cc.Budgets
            //                 on ideaRisk.IdeaID equals budget.IdeaID
            //                 join ideaDoc in this.cc.IdeaDocuments
            //                 on ideaRisk.IdeaID equals ideaDoc.IdeaID
            //                 select new { ideaRisk, member, stages, budget, ideaDoc };
            //foreach (var temp in allRecords)
            //{
            //    this.cc.IdeaRisks.Remove(temp.ideaRisk);
            //    this.cc.Budgets.Remove(temp.budget);
            //    this.cc.Members.Remove(temp.member);
            //    this.cc.Stages.Remove(temp.stages);
            //    this.cc.IdeaDocuments.Remove(temp.ideaDoc);

            //}
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
    }
}
