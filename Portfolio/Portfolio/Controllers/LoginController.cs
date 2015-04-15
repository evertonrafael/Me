using Model;
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
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Usuario usu)
        {
            var usuarioLogado = UOW.UsuarioRepository.Get(f => f.Email == usu.Email && f.Senha == usu.Senha);           
            if (usuarioLogado != null && usuarioLogado.Count() > 0)
            {
                Session["usuario"] = usuarioLogado;
                return RedirectToAction("../Admin");
            }

            ModelState.AddModelError("usuarioousenhaeinvalidos", "Usuário ou senha inválidos.");
            return View("Index");
        }
    }
}