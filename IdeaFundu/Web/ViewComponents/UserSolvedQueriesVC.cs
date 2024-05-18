using Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Repository;

namespace Web.ViewComponents
{
    public class UserSolvedQueriesVC : ViewComponent
    {
        IQuery QueryRepo;
        public UserSolvedQueriesVC(IQuery _QueryRepo)
        {
            QueryRepo = _QueryRepo;
        }

        public IViewComponentResult Invoke(Int64 id)
        {
            Int64 UserID = Convert.ToInt64(HttpContext.Session.GetString("UserID"));
            var v = this.QueryRepo.GetAllAcceptedQueries(UserID);
            return View(v.ToList());
        }
    }
}