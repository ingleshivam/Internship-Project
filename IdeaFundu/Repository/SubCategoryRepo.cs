using Core;
using Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SubCategoryRepo: GenericRepo<SubCategory>, ISubCategory
    {
        CompanyContext cc;
        public SubCategoryRepo(CompanyContext cc) : base(cc)
        {
            this.cc = cc;
        }

    }
}
