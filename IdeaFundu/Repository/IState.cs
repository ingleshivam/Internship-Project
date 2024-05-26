using Core;
using Repository.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IState:IGeneric<State>
    {
        List<StateVM> GetStatesByCountryId(Int64 countryID);
        bool GetByName(string name);
    }
}
