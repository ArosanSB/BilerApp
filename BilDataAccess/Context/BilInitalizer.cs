using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilDataAccess.Context
{
    public class BilInitalizer : CreateDatabaseIfNotExists<BilContext>
    {
        protected override void Seed(BilContext context)
        {

            context.Biler.Add(new Model.Bil("CH97259","Peugeot","208",2019));
            context.SaveChanges();
        }
    }
}
