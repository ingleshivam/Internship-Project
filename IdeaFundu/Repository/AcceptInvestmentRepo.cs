using Core;
using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AcceptInvestmentRepo : GenericRepo<AcceptInvestment>, IAcceptInvestment
    {
        CompanyContext cc;
        public AcceptInvestmentRepo(CompanyContext cc) : base(cc)
        {
            this.cc = cc;
        }
    }
}
