using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Repository;

namespace Web.ViewComponents
{
    public class IdeaListVC: ViewComponent
    {
        IIdea IdeaRepo;
        public IdeaListVC(IIdea _IdeaRepo)
        {
            IdeaRepo = _IdeaRepo;
        }

        public IViewComponentResult Invoke(List<Idea> records)
        {
            if(records != null)
            {
                return View(records.ToList());
            }
            else
            {
                return View(this.IdeaRepo.GetAll());
            }
        }
    }
}
