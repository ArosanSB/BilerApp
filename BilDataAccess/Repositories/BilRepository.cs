using DTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilDataAccess.Context;
using BilDataAccess.Mappers;
using BilDataAccess.Model;
using System.Data.Entity.Core.Objects;

namespace BilDataAccess.Repositories
{
    public class BilRepository
    {
        public static BilDTO getBil(string regNr)
        {
            using (BilContext context = new BilContext())
            {
                return BilMapper.Map(context.Biler.Find(regNr));
            }
        }

        public static void AddBil(BilDTO bil)
        {
            using (BilContext context = new BilContext())
            {
                context.Biler.Add(BilMapper.Map(bil));
                context.SaveChanges();            
            }
        }

        public static List<BilDTO> GetAllCars()
        {
            using (BilContext context = new BilContext())
            {
                return context.Biler.ToList().ConvertAll<BilDTO>((Bil car) =>
                {
                    return BilMapper.Map(car);
                });

            }
        }

        public static void UpdateCar(BilDTO bil)
        {
            using (BilContext context = new BilContext())
            {
                Bil car = context.Biler.Find(bil.RegNr);
                context.Entry(car).CurrentValues.SetValues(bil);
                context.SaveChanges();
            }
        }
        
        public static bool DeleteCar(String Regnr)
        {
            using (BilContext context = new BilContext())
            {
                Bil bil = context.Biler.Find(Regnr);
                context.Biler.Remove(bil);
                context.SaveChanges();
                return true;
            }
        }
    } 
}
