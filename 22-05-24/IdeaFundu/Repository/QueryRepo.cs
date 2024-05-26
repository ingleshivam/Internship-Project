using Core;
using Infra;
using Repository.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class QueryRepo:GenericRepo<Query>,IQuery
    {
        CompanyContext cc;
        public QueryRepo(CompanyContext cc) : base(cc)
        {
            this.cc = cc;
        }

        public List<Query> GetAllAcceptedQueries(Int64 UserID)
        {
            var v = from t in this.cc.Queries
                    join t1 in this.cc.Solutions
                    on t.QueryID equals t1.QueryID
                    where t.Idea.UserID == UserID
                    select t;
            return v.ToList();
        }

        public List<Query> GetAllQueries(Int64 UserID)
        {
            var v = from t in this.cc.Queries
                    where !(from t1 in this.cc.Solutions
                            select t1.QueryID)
                            .Contains(t.QueryID) && t.Idea.UserID == UserID
                    select t;

            return v.ToList();
        }

        public RepoResultVM GiveQuerySolution(Solution rec)
        {

            RepoResultVM res = new RepoResultVM();
            try
            {
                rec.SolutionDate = DateTime.Now;
                this.cc.Solutions.Add(rec);
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Solution Submitted !";
                return res;
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.ToString();
            }

            return res;
        }

        public Solution GetSolutionByQueryID(long QueryID)
        {
            var v = this.cc.Solutions.FirstOrDefault(p => p.QueryID == QueryID);
            return v;
        }

        public List<Query> GetAllPendingQueriesByInvestorID (Int64 InvestorID)
        {
            var v = from t in this.cc.Queries.Where(p => p.InvestorID == InvestorID) select t;
            return v.ToList();
        }

        public List<Query> GetAllSolvedQueriesByInvestorID(long InvestorID)
        {
            var v = from t in this.cc.Queries
                    join t1 in this.cc.Solutions
                    on t.QueryID equals t1.QueryID
                    where t.InvestorID == InvestorID
                    select t;
            return v.ToList();
        }
    }
}
