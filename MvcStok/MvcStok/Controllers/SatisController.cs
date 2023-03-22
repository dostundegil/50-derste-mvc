using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcStok.Models.Entity;
namespace MvcStok.Controllers
{
    public class SatisController : Controller
    {
        MvcDbStokEntities1 db = new MvcDbStokEntities1();
        // GET: Satis
        public ActionResult Index()
        {
            var degerler = db.TBLURUNLER.ToList();
            return View();
        }
        [HttpGet]
        public ActionResult YeniSatis()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniSatis(TBLSATISLAR p)
        {
            db.TBLSATISLAR.Add(p);
            db.SaveChanges();
            return View("Index");
        }
        
    }
}