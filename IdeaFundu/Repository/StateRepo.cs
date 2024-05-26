using Core;
using Infra;
using Repository.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
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

        public List<StateVM> GetStatesByCountryId(long countryID)
        {
            var v = from t in this.cc.States
                    where t.CountryID == countryID
                    select new StateVM
                    {
                        StateID = t.StateID,
                        StateName = t.StateName
                    };

            return v.ToList();
        }

        public bool GetByName(string name)
        {
            var record = this.cc.States.SingleOrDefault(p => p.StateName == name);
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
