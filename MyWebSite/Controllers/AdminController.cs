using MyWebSite.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebSite.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var deger = c.homes.ToList();
            return View(deger);
        }
        public ActionResult ComeHome(int id)
        {
            var ag = c.homes.Find(id);
            return View("ComeHome" ,ag);
        }
        public ActionResult HomeUpdate(Home x)
        {
            var ag = c.homes.Find(x.id);
            ag.Name = x.Name;
            ag.profil = x.profil;
            ag.departmen = x.departmen;
            ag.communication = x.communication;
            ag.explanation = x.explanation;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult iconList()
        {
            var deger = c.Icons.ToList();
            return View(deger);
        }

        [HttpGet]  //sayfa yüklendiğinde çalışsın
        public ActionResult newIcon()
        {
            return View();
        }
        [HttpPost]
        public ActionResult newIcon(Icon p)
        {
            c.Icons.Add(p);
            c.SaveChanges();
            return RedirectToAction("iconList");
        }

        public ActionResult comeIcon(int id)
        {
            var ig = c.Icons.Find(id);
            return View("comeIcon", ig);
        }
        public ActionResult UpdateIcon(Icon x)
        {
            var ig = c.Icons.Find(x.id);
            ig.icon = x.icon;
            ig.link = x.link;
            c.SaveChanges();
            return RedirectToAction("iconList");
        }
        public ActionResult deleteIcon(int id)
        {
            var di = c.Icons.Find(id);
            c.Icons.Remove(di);
            c.SaveChanges();
            return RedirectToAction("iconList");

        }
    }
}