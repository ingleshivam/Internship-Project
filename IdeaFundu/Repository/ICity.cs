using Core;
using Repository.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ICity:IGeneric<City>
    {
        List<GetCitiesVM> GetCitiesByStateId(Int64 stateID);
        void AddRecord(CityVM rec);
        void EditRecord(CityVM rec);
        CityVM GetCityById(Int64 id);
        bool GetByName(string name);
    }
}
