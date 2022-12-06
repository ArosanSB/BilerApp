using BusniessLogic.BLL;
using DTO.Model;
using System.Collections.Generic;
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
        public BilDTO GetBil(string id)
        {
            return car.getCar(id);
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
