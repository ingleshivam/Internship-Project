using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Repository;

namespace Web.ViewComponents
{
    public class MembersVC : ViewComponent
    {
        IMember MemberRepo;
        public MembersVC(IMember _MemberRepo)
        {
            MemberRepo = _MemberRepo;
        }

        public IViewComponentResult Invoke(Int64 id)
        {
            var v = from t in this.MemberRepo.GetAll().Where(p => p.IdeaID == id)
                    select t;
            return View(v.ToList());
        }
    }
}
