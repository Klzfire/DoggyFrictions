﻿using System.Web.Mvc;

namespace DoggyFriction.Controllers
{
    public class TemplatesController : Controller
    {
        public ActionResult Get()
        {
            return PartialView("Templates");
        }
    }
}