using BilDataAccess.Model;
using BilDataAccess.Repositories;
using DTO.Model;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BusniessLogic.BLL
{
    public class BilBLL
    {
        public BilDTO getCar(string regNr)
        {
            if (string.IsNullOrEmpty(regNr)) throw new Exception("Error: Regnr findes ikke");
            return BilDataAccess.Repositories.BilRepository.getBil(regNr);
        }

        public void AddCar(BilDTO bil)
        {
            BilRepository.AddBil(bil);

        }


        public void CreateCar(string regNr, string mærke, string model, int aargang)
        {
            BilDTO bil = new BilDTO(regNr,mærke,model,aargang);
            AddCar(bil);
        }


        public void UpdateCar(BilDTO bil)
        {
            BilRepository.UpdateCar(bil);
        }


        public List<BilDTO> getAllCars()
        {
            return BilRepository.GetAllCars();
        }

       
        public bool DeleteCar(string regNr)
        {
            if (!string.IsNullOrEmpty(regNr))
            {
                if (getCar(regNr).RegNr.Equals(regNr))
                {
                    BilRepository.DeleteCar(regNr);
                }
            }
            return false;
        }
        

    }
}
