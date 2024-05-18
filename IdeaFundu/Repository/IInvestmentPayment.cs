using Core;
using Repository.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IInvestmentPayment : IGeneric<InvestmentPayment>
    {
        void AddRecord(InvestmentPayment rec);
        InvestmentPayment GetInvestmentPaymentDetails(AcceptInvestmentVM rec);
        IEnumerable<IdeaInvestmentTotalVM> GetAllIdeasTotal(Int64 UserID);
        IEnumerable<InvestmentPaymentsVM> GetAllIdeasById(Int64 UserID,Int64 IdeaID);
        IEnumerable<WorkProgressClosureVM> GetWorkProgressByIdeaId(Int64 IdeaID);
    }
}
