using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EliseKalokerinos.Controllers
{
    public class NewsController : Controller
    {
        //
        // GET: /News/
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Home");

            // Hiding News for Now
            //return View();
        }
	}
}