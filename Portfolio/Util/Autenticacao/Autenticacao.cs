using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Routing;
using System.Web.Mvc;


namespace Util.Autenticacao
{
    public class Autenticacao : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            object sessaoUsuario = filterContext.HttpContext.Session["usuario"];
            if (sessaoUsuario != null)
            {
                base.OnActionExecuted(filterContext);
            }
            else
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
                {
                    controller = "Login",
                    action = "Index"
                }));
            }
        }
    }
}
