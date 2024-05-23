using BusniessLogic.BLL;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BilWebApp.Controllers
{
    public class HomeController : Controller
    {
        private BilBLL BilBLL = new BilBLL();

        public ActionResult Index()
        {
            return View();
        }



        public ActionResult Cars()
        {
            List<BilDTO> cars = BilBLL.getAllCars();
            ViewBag.Cars = cars;

            return View(cars);
           
        }



        [HttpGet]
        public ActionResult CreateCar()
        {
            ViewBag.ActionMetod = "CreateCar";
            ViewBag.Title = "Opret bil";

            return View("Form");
        }

        [HttpPost]
        public ActionResult CreateCar(BilDTO bil)
        {
            if (ModelState.IsValid)
            {
                BilBLL.AddCar(bil);
            }

            return RedirectToAction("Cars");

        }


        [HttpGet]
        public ActionResult UpdateCar(string id)
        {
            ViewBag.ActionMetod = "UpdateCar";
            ViewBag.Title = "Opdatere bil";

            BilDTO car = BilBLL.getCar(id);

            return View("Form",car);
        }

        [HttpPost]
        public ActionResult UpdateCar(BilDTO bil)
        {
            if (ModelState.IsValid)
            {
                BilBLL.UpdateCar(bil);
            }

            return RedirectToAction("Cars");
        }


     

        public ActionResult DeleteCar(String id)
        {
            if (ModelState.IsValid)
            {
                BilBLL.DeleteCar(id);
            }
            return RedirectToAction("Cars");

        }









        public ActionResult About()
        {
            ViewBag.Message = "Her ser man klasse-diagrammet af programmet :)";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Arosan Suresh Balasingam";

            return View();
        }
    }
}