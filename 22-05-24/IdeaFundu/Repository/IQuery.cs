using Core;
using Repository.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IQuery:IGeneric<Query>
    {
        List<Query> GetAllQueries(Int64 UserID);
        List<Query> GetAllAcceptedQueries(Int64 UserID);
        RepoResultVM GiveQuerySolution(Solution rec);
        Solution GetSolutionByQueryID(Int64 QueryID);
        List<Query> GetAllPendingQueriesByInvestorID(Int64 InvestorID);
        List<Query> GetAllSolvedQueriesByInvestorID(Int64 InvestorID);
    }
}
