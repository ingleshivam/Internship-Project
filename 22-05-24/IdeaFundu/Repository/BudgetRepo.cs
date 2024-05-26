using Core;
using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BudgetRepo : GenericRepo<Budget>, IBudget
    {
        CompanyContext cc;
        public BudgetRepo(CompanyContext cc) : base(cc)
        {
            this.cc = cc;
        }
    }
}
