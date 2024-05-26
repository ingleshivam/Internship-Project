using Core;
using Infra;
using Repository.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RiskListRepo : GenericRepo<IdeaRisk>, IRisk
    {
        CompanyContext cc;
        public RiskListRepo(CompanyContext cc) : base(cc)
        {
            this.cc = cc;
        }

        public void AddRecord(IdeaRiskVM rec)
        {
            throw new NotImplementedException();
        }

        public List<IdeaRisk> GetAllByUserID(long userid)
        {
            throw new NotImplementedException();
        }

        public List<RiskListVM> GetIdeasByIdeaId(long id)
        {
            throw new NotImplementedException();
        }
    }
}
