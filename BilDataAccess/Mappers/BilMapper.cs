using BilDataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Model;

namespace BilDataAccess.Mappers
{
    public class BilMapper
    {
        public static BilDTO Map(Bil bil)
        {
            return new BilDTO(bil.RegNr, bil.Mærke, bil.Model, bil.Aargang, bil.kM);
        }

        public static Bil Map(BilDTO bil)
        {
            return new Bil(bil.RegNr, bil.Mærke, bil.Model, bil.Aargang);
        }
    }
}
