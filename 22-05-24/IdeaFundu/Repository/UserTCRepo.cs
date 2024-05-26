using Core;
using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserTCRepo:GenericRepo<UserTC>,IUserTC
    {
        CompanyContext cc;
        public UserTCRepo(CompanyContext cc) : base(cc)
        {
            this.cc = cc;
        }
    }
}
