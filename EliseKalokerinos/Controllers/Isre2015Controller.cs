using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EliseKalokerinos.Controllers
{
    public class Isre2015Controller : Controller
    {
        // GET: Isre2015
        public ActionResult Index()
        {
            return new FilePathResult("~/Documents/ISRE 2015 poster Elise Kalokerinos.pdf", "application/pdf");
        }
    }
}