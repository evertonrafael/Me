using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Util.Autenticacao;

namespace Portfolio.Controllers
{
    [Autenticacao]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult MenuSideBar()
        {
            return PartialView("_MenuSideBar");
        }
    }
}