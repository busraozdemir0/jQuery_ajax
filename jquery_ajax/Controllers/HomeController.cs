﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace jquery_ajax.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DosyaOkuma()
        {
            return View();
        }
        public ActionResult AJAXDosyaOku()
        {
            return View();
        }
        public ActionResult AjaxXMLDosyaOku()
        {
            return View();
        }
        public ActionResult JsonOku()
        {
            return View();
        }
    }
}