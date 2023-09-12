using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1_MVC_Country_State_City_Registration2.Models;

namespace WebApplication1_MVC_Country_State_City_Registration2.Data
{
    public class RegisterDbContext:DbContext
    {
        public RegisterDbContext()
        {

        }
        public DbSet<Country> Countries { get; set; }

        public DbSet<State> States { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Registration> Registrations { get; set; }
    }
}