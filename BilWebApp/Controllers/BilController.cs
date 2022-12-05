using BusniessLogic.BLL;
using DTO.Model;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Web.Http;

namespace BilWebApp.Controllers
{
    public class BilController : ApiController
    {

        private BilBLL car = new BilBLL();

        [HttpGet]
        public IEnumerable<BilDTO> Get()
        {
            return car.getAllCars();
        }



        [HttpGet]
        public BilDTO GetBil(string regNr)
        {
            return car.getCar(regNr);
        }

        [HttpPost]
        public BilDTO AddCar(BilDTO bil)
        {
            car.AddCar(bil);
            return bil;
        }

        [HttpDelete]
        public bool DeleteCar(string regNr)
        {
            return car.DeleteCar(regNr);
        }

    }
}
