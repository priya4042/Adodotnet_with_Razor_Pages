using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1_MVC_country_city_state_5.Models;

namespace WebApplication1_MVC_country_city_state_5.Data
{
    public class RegistrationDbContext:DbContext
    {
        public RegistrationDbContext():base("ctrS")
        {
                
        }
        public DbSet<Country> Countries { get; set; }   

        public DbSet<State> States { get; set; }

        public DbSet<City> City { get; set; }

        public DbSet<Register> Registers { get; set; }
    }
}