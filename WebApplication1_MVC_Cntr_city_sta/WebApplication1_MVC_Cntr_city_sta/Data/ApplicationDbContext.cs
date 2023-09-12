using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1_MVC_Cntr_city_sta.Models;

namespace WebApplication1_MVC_Cntr_city_sta.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext():base("Cmtr")
        {

        }
        public DbSet<Country> Countries { get; set; }

        public DbSet<State> States { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Register> Registers { get; set; }
    }
}       