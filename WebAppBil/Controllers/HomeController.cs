using BusniessLogic.BLL;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAppBil.Controllers
{
    public class HomeController : Controller
    {
        private BilBLL BilBLL = new BilBLL();
        // GET: Home

        public ActionResult Index()
        {
            
           
            return View();
        }

        [HttpPost]
        public ActionResult Index(Bil bil)
        {
            if (ModelState.IsValid)
            {
                BilBLL.AddBil(bil);

            }

            return View(bil);
        }


    }
}