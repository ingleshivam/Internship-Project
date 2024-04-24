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
    }
}
