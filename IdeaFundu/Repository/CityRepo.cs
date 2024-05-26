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

        public void AddRecord(CityVM rec)
        {
            City city = new City();
            city.CityName = rec.CityName;
            city.StateID = rec.StateID;
            this.cc.Cities.Add(city);
            this.cc.SaveChanges();
        }

        public void EditRecord(CityVM rec)
        {
            City city = new City();
            city.CityID = rec.CityID;
            city.CityName = rec.CityName;
            city.StateID = rec.StateID;
            this.cc.Entry(city).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            this.cc.SaveChanges();

        }

        public CityVM GetCityById(long id)
        {
            var record = from t in this.cc.Cities
                         where t.CityID == id
                         select new CityVM
                         {
                             CityID = t.CityID,
                             CityName = t.CityName,
                             StateID = t.StateID,
                             CountryID = t.State.CountryID
                         };

            return record.FirstOrDefault();
        }

        public bool GetByName(string name)
        {
            var record = this.cc.Cities.SingleOrDefault(p => p.CityName == name);
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
