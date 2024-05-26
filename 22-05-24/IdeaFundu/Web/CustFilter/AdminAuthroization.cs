using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Web.CustFilter
{
    public class AdminAuthroization : ActionFilterAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (context.HttpContext.Session.GetString("AdminID") == null)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { action = "SignIn", controller = "ManageAdmins", area = "" }));
            }
        }
    }
}
