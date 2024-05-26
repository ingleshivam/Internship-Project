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

        public bool GetByName(string name)
        {
            var record = this.cc.UserTCs.SingleOrDefault(p => p.UserTCTitle == name);
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
