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
    public class CubeController : Controller
    {
        private CubeService service = new CubeService();
        // GET: Barrel

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cube cube = service.GetCubeById((int)id);
            if (cube == null)
            {
                return HttpNotFound();
            }
            return View(cube);
        }


        public ActionResult Index()
        {
            return View(service.GetAllCubes());
        }
        public ActionResult CreateCube()
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
        public ActionResult CreateCube(Cube cube)
        {
            if (ModelState.IsValid)
            {
                service.AddCube(cube);
                return RedirectToAction("Index");
            }

            return View(cube);
        }

        public ActionResult EditCube(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cube cube = service.GetCubeById((int)id);
            if (cube == null)
            {
                return HttpNotFound();
            }
            return View(cube);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCube(Cube cube)
        {
            if (ModelState.IsValid)
            {
                service.EditBarrel(cube);
                return RedirectToAction("Index");
            }
            return View(cube);
        }
        public ActionResult AboutUs()
        {
            return View();
        }


        public ActionResult DeleteCube(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cube cube = service.GetCubeById((int)id);
            if (cube == null)
            {
                return HttpNotFound();
            }
            return View(cube);
        }


        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cube cube = service.GetCubeById(id);
            service.DeleteCube(cube);
            return RedirectToAction("Index");
        }

        

    }
}
