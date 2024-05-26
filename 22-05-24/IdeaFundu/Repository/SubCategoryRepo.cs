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
    public class SubCategoryRepo: GenericRepo<SubCategory>, ISubCategory
    {
        CompanyContext cc;
        public SubCategoryRepo(CompanyContext cc) : base(cc)
        {
            this.cc = cc;
        }

        public List<GetSubCategoriesVM> GetSubCategoriesByCategoryId(long id)
        {
            var v = from t in this.cc.SubCategories
                    where t.CategoryID == id
                    select new GetSubCategoriesVM
                    {
                        SubCategoryID = t.SubCategoryID,
                        SubCategoryName = t.SubCategoryName
                    };

            return v.ToList();
        }
    }
}
