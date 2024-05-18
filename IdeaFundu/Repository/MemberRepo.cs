using Core;
using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class MemberRepo : GenericRepo<Member>, IMember
    {
        CompanyContext cc;
        public MemberRepo(CompanyContext cc) : base(cc)
        {
            this.cc = cc;
        }

        public List<Member> GetAllByUserID(long userid)
        {
            return this.cc.Members.Where(p => p.Idea.UserID == userid).ToList();
        }
    }
}
