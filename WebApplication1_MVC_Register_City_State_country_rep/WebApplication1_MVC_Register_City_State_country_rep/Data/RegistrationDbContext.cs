using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1_MVC_Register_City_State_country_rep.Models;

namespace WebApplication1_MVC_Register_City_State_country_rep.Data
{
    public class RegistrationDbContext:DbContext
    {
        public RegistrationDbContext():base("cntRl")
        {

        }
        public DbSet<Country> Countries { get; set; }

        public DbSet<State> States { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Reistration> Reistrations { get; set; }
    }
}