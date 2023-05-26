using MyWebSite.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebSite.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        Context c = new Context();
        public ActionResult Index()
        {
            var deger = c.homes.ToList();
            return View(deger);
        }
        public PartialViewResult Icon()
        {
            var deger = c.Icons.ToList();
            return PartialView(deger);
        }
    }
}