using Core;
using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class InvestorTCRepo : GenericRepo<InvestorTC>, IInvestorTC
    {
        CompanyContext cc;
        public InvestorTCRepo(CompanyContext cc) : base(cc)
        {
            this.cc = cc;
        }
    }
}
