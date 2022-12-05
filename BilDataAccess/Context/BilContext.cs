using BilDataAccess.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilDataAccess.Context
{
    public class BilContext : DbContext
    {
        public BilContext() : base("Biler")
        {

        }

        public DbSet<Bil> Biler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}
