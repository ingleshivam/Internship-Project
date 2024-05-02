using Core;
using Infra;
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

        public void DeleteRecord(long id)  //10007 ideaid
        {
            //find budget record
            var budgetRecord = this.cc.Budgets.Where(p => p.IdeaID == id);
            foreach(var temp in budgetRecord)
            {
                this.cc.Budgets.Remove(temp);
            }
            this.cc.SaveChanges();

            //find idea record
            var ideaRecord = this.cc.Ideas.Find(id);
            this.cc.Ideas.Remove(ideaRecord);
            this.cc.SaveChanges();
        }

        public void EditRecord(Idea rec)
        {
            Idea idea = new Idea();
            idea.IdeaName = rec.IdeaName;
            idea.SubCategoryID = rec.SubCategoryID;
            idea.Budget = new Budget();
            idea.Budget.BudgetAmount = rec.Budget.BudgetAmount;
            idea.Budget.MaximumInvestmentLimit = rec.Budget.MaximumInvestmentLimit;
            idea.Budget.MinimumInvestmentLimit = rec.Budget.MinimumInvestmentLimit;
            idea.UserID = rec.UserID;
            this.cc.Ideas.Add(idea);
            this.cc.SaveChanges();
        }
    }
}
