using Core;
using Repository.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ISubCategory:IGeneric<SubCategory>
    {
        List<GetSubCategoriesVM> GetSubCategoriesByCategoryId(Int64 id);
        bool GetByName(string name);
    }
}
