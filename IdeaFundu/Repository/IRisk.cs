using Core;
using Repository.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRisk : IGeneric<IdeaRisk>
    {
        List<RiskListVM> GetIdeasByIdeaId(Int64 id);
        List<IdeaRisk> GetAllByUserID(Int64 userid);
    }
}
