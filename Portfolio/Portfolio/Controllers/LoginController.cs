using Repository.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class LoginController : Controller
    {
        private UnitOfWork UOW = new UnitOfWork();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(string email, string senha)
        {
            var usuarioLogado = UOW.UsuarioRepository.Get(f => f.Email == email && f.Senha == senha);
            if (usuarioLogado != null && usuarioLogado.Count() > 0)
            {
                Session["usuario"] = usuarioLogado;
                return RedirectToAction("../Admin");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}