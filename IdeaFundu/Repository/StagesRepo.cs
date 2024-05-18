using Core;
using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class StagesRepo : GenericRepo<Stages>, IStages
    {
        CompanyContext cc;
        public StagesRepo(CompanyContext cc) : base(cc)
        {
            this.cc = cc;
        }

        public List<Stages> GetAllByUserID(long userid)
        {
            return this.cc.Stages.Where(p => p.Idea.UserID == userid).ToList();
        }
    }
}
