using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Repository;

namespace Web.ViewComponents
{
    public class UserNewQueriesVC : ViewComponent
    {
        IQuery QueryRepo;
        public UserNewQueriesVC(IQuery _QueryRepo)
        {
            QueryRepo = _QueryRepo;
        }

        public IViewComponentResult Invoke(Int64 id)
        {
            Int64 UserID = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            var v = this.QueryRepo.GetAllQueries(UserID);
            return View(v.ToList());
        }
    }
}