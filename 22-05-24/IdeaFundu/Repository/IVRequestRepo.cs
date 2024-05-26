using Core;
using Infra;
using Infra.Migrations;
using Repository.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class IVRequestRepo : GenericRepo<IVRequest>, IIVRequest
    {
        CompanyContext cc;
        public IVRequestRepo(CompanyContext cc) : base(cc)
        {
            this.cc = cc;
        }

        public RepoResultVM AcceptPendingRequest(AcceptInvestment rec)
        {

            RepoResultVM res = new RepoResultVM();
            try
            {
                this.cc.AcceptInvestments.Add(rec);
                this.cc.SaveChanges();
                res.IsSuccess = true;
                res.Message = "Investment Request Accepted !";
                return res;
            }
            catch (Exception ex)
            {
                res.IsSuccess = false;
                res.Message = ex.ToString();
            }

            return res;
        }

        public List<IVRequest> GetAllAcceptedInvestments(Int64 UserID)
        {
            var v = from t in this.cc.IVRequests
                    join t1 in this.cc.AcceptInvestments
                    on t.IVRequestID equals t1.IVRequestID
                    where t.Idea.UserID == UserID
                    select t;

            return v.ToList();
        }

        public List<IVRequest> GetAllAcceptedInvestmentsByInvestorID(long InvestorID)
        {
            var v = from t in this.cc.IVRequests
                    join t1 in this.cc.AcceptInvestments
                    on t.IVRequestID equals t1.IVRequestID
                    where t.InvestorID == InvestorID
                    select t;
            return v.ToList();
        }

        public List<IVRequest> GetAllPendingInvestments(Int64 UserID)
        {
            var v = from t in this.cc.IVRequests
                    where !(from t1 in this.cc.AcceptInvestments
                            select t1.IVRequestID)
                            .Contains(t.IVRequestID) && t.Idea.UserID == UserID
                    select t;

            return v.ToList();
        }

        public List<IVRequest> GetAllPendingInvestmentsByInvestorID(long InvestorID)
        {
            var v = from t in this.cc.IVRequests.Where(p => p.InvestorID == InvestorID) select t;
            return v.ToList();
        }

        public AcceptInvestmentVM GetInvestmentByRequestID(long IVRequestID)
        {
            var v = this.cc.AcceptInvestments.FirstOrDefault(p => p.IVRequestID == IVRequestID);
            AcceptInvestmentVM aivm = new AcceptInvestmentVM();
            aivm.AcceptIVID = v.AcceptIVID;
            aivm.AcceptIVDesc = v.AcceptIVDesc;
            aivm.AmountAccepted = v.AmountAccepted;
            aivm.IVRequestID = v.IVRequestID;

            return aivm;
        }
    }
}
