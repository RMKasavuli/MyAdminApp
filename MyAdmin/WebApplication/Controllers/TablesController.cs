﻿using System.Web.Mvc;

namespace MyAdmin.Controllers
{
    public class TablesController : Controller
    {
        public ActionResult Simple()
        {
            return View();
        }

        public ActionResult Data()
        {
            return View();
        }
    }
}