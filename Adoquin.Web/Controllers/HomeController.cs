﻿using System.Web.Mvc;

namespace Adoquin.Web.Controllers
{
    public class HomeController : AppController
    {
        public ActionResult Index()
        {
            //string _nombre = "marcelo";
            //ViewBag.Nombre = _nombre;
            return View();
        }
	}
}