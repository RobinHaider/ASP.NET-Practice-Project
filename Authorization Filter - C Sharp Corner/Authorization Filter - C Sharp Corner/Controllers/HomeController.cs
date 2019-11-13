﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Authorization_Filter___C_Sharp_Corner.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult NonSecured()
        {
            return View();
        }
        [Authorize]
        public ActionResult Secured()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }
    }
}