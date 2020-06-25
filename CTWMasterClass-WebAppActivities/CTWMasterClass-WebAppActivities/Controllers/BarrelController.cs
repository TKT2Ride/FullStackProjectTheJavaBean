using CTWMasterClass_WebAppActivities.Models;
using CTWMasterClass_WebAppActivities.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CTWMasterClass_WebAppActivities.Controllers
{
    public class BarrelController : Controller
    {
        private BarrelService service = new BarrelService();
        // GET: Barrel
        public ActionResult Index()
        {
            return View(service.GetAllBarrels());
        }
        public ActionResult Create()
        {
            return View();
        }
        
        public ActionResult Sort()
        {
            return View(service.SortWeightHL());
        }
        
        public ActionResult WeightLH()
        {
            return View(service.SortWeightLH());
        }
        public ActionResult WeightHL()
        {
            return View(service.SortWeightHL());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Barrel barrel)
        {
            if (ModelState.IsValid)
            {
                service.AddBarrel(barrel);
                return RedirectToAction("Index");
            }

            return View(barrel);
        }
    }
}

