using Core;
using Infra;
using Microsoft.Identity.Client;
using Repository.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RiskRepo : GenericRepo<IdeaRisk>, IRisk
    {
        CompanyContext cc;
        public RiskRepo(CompanyContext cc) : base(cc)
        {
            this.cc = cc;
        }

        public List<IdeaRisk> GetAllByUserID(long userid)
        {
            return this.cc.IdeaRisks.Where(p => p.Idea.UserID == userid).ToList();
        }

        public List<RiskListVM> GetIdeasByIdeaId(long id)
        {
            if(id != 0)
            {
                var v = from t in this.cc.IdeaRisks
                        where t.IdeaID == id
                        select new RiskListVM
                        {
                            RiskID = t.RiskID,
                            IdeaID = t.IdeaID,
                            RiskTitle = t.RiskTitle,
                            RiskDescription = t.RiskDescription,
                            RiskLevel = t.RiskLevel
                        };
                return v.ToList();
            }
            else
            {
                var v1 = from t in this.cc.IdeaRisks
                         select new RiskListVM
                         {
                             RiskID = t.RiskID,
                             RiskTitle = t.RiskTitle,
                             RiskDescription = t.RiskDescription,
                             RiskLevel = t.RiskLevel
                         };
                return v1.ToList();
            }
        }
    }
}
