using Core;
using Infra;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CategoryRepo:GenericRepo<Category>,ICategory
    {
        CompanyContext cc;
        public CategoryRepo(CompanyContext cc):base(cc)
        {
            this.cc = cc;
        }
    }
}
