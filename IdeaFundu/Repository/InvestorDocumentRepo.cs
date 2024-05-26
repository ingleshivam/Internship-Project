using Core;
using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class InvestorDocumentRepo : GenericRepo<InvestorDocument>, IInvestorDocument
    {
        CompanyContext cc;
        public InvestorDocumentRepo(CompanyContext cc) : base(cc)
        {
            this.cc = cc;
        }

        public bool GetByName(string name)
        {
            var record = this.cc.InvestorDocuments.SingleOrDefault(p => p.CIN == name);
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
