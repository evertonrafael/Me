﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Util.Autenticacao;

namespace Portfolio.Controllers
{
    [Autenticacao]
    [NoCacheAttribute]
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

        public ActionResult CriacaoPost()
        {
            return View();
        }
        public ActionResult Sobre()
        {
            return View();
        }
        public ActionResult Posts()
        {
            return View();
        }
    }
}