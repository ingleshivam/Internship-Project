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

        public bool GetByName(string name)
        {
            var record = this.cc.InvestorTCs.SingleOrDefault(p => p.InvestorTCTitle == name);
            if (record != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
