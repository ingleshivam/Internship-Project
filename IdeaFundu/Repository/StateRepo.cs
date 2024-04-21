using Core;
using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class StateRepo:GenericRepo<State>,IState
    {
        CompanyContext cc;
        public StateRepo(CompanyContext cc) : base(cc)
        {
            this.cc = cc;
        }
    }
}
