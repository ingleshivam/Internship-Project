using Core;
using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CountryRepo:GenericRepo<Country>,ICountry
    {
        CompanyContext cc;
        public CountryRepo(CompanyContext cc) : base(cc)
        {
            this.cc = cc;
        }
    }
}
