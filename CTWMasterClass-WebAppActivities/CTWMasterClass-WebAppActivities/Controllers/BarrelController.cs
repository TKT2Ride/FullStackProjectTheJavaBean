using CTWMasterClass_WebAppActivities.Models;
using CTWMasterClass_WebAppActivities.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace CTWMasterClass_WebAppActivities.Controllers
{
    public class BarrelController : Controller
    {
        private BarrelService service = new BarrelService();
        // GET: Barrel

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Barrel barrel = service.GetBarrelById((int)id);
            if (barrel == null)
            {
                return HttpNotFound();
            }
            return View(barrel);
        }


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

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Barrel barrel = service.GetBarrelById((int)id);
            if (barrel == null)
            {
                return HttpNotFound();
            }
            return View(barrel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Barrel barrel)
        {
            if (ModelState.IsValid)
            {
                service.EditBarrel(barrel);
                return RedirectToAction("Index");
            }
            return View(barrel);
        }
        public ActionResult AboutUs()
        {
            return View();
        }


        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Barrel barrel = service.GetBarrelById((int)id);
            if (barrel == null)
            {
                return HttpNotFound();
            }
            return View(barrel);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Barrel barrel = service.GetBarrelById(id);
            service.DeleteBarrel(barrel);
            return RedirectToAction("Index");
        }

        

    }
}

