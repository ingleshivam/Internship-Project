using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Repository;

namespace Web.ViewComponents
{
    public class DropDownSearchVC: ViewComponent
    {
        ISubCategory SubCategoryRepo;
        ICategory CategoryRepo;
        public DropDownSearchVC(ISubCategory _SubCategoryRepo, ICategory _CategoryRepo)
        {
            SubCategoryRepo = _SubCategoryRepo;
            CategoryRepo = _CategoryRepo;
        }

        public IViewComponentResult Invoke(Int64 id)
        {
            ViewBag.CategoryID = new SelectList(this.CategoryRepo.GetAll(), "CategoryID", "CategoryName");
            ViewBag.SubCategoryID = new SelectList(this.SubCategoryRepo.GetAll(), "SubCategoryID", "SubCategoryName");
            return View();
        }
    }


}
