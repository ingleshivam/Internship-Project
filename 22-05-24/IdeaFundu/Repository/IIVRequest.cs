using Core;
using Repository.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IIVRequest : IGeneric<IVRequest>
    {
        List<IVRequest> GetAllPendingInvestments(Int64 UserID);
        List<IVRequest> GetAllAcceptedInvestments(Int64 UserID);
        RepoResultVM AcceptPendingRequest(AcceptInvestment rec);
        AcceptInvestmentVM GetInvestmentByRequestID(Int64 IVRequestID);
        List<IVRequest> GetAllPendingInvestmentsByInvestorID(Int64 InvestorID);
        List<IVRequest> GetAllAcceptedInvestmentsByInvestorID(Int64 InvestorID);
    }
}
