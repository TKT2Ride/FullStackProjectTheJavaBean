using CTWMasterClass_WebAppActivities.Models;
using CTWMasterClass_WebAppActivities.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CTWMasterClass_WebAppActivities.Controllers
{
    public class HomeController : Controller
    {
        private BarrelService BarrelService = new BarrelService();
        private CubeService CubeService = new CubeService();
        public ActionResult Index()
        {
            ViewModel mymodel = new ViewModel();
            mymodel.Cubes = CubeService.GetAllCubes();
            mymodel.Barrels = BarrelService.GetAllBarrels();
            return View(mymodel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}