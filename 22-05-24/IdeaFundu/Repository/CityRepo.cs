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
    public class CityRepo:GenericRepo<City>,ICity
    {
        CompanyContext cc;
        public CityRepo(CompanyContext cc) : base(cc)
        {
            this.cc = cc;
        }

        public List<GetCitiesVM> GetCitiesByStateId(long stateID)
        {
            var v = from t in this.cc.Cities
                    where t.StateID == stateID
                    select new GetCitiesVM
                    {
                        CityID = t.CityID,
                        CityName = t.CityName
                    };

            return v.ToList();
        }
    }
}
