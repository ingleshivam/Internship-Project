using Core;
using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class PreviousWorkRepo : GenericRepo<PreviousWork>, IPreviousWork
    {
        CompanyContext cc;
        public PreviousWorkRepo(CompanyContext cc) : base(cc)
        {
            this.cc = cc;
        }
    }
}
