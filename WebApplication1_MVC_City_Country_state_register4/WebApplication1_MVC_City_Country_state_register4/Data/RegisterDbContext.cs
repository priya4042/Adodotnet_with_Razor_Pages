using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1_MVC_City_Country_state_register4.Models;

namespace WebApplication1_MVC_City_Country_state_register4.Data
{
    public class RegisterDbContext:DbContext
    {
        public RegisterDbContext():base("cnStr")
        {

        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Register> Registers { get; set; }
    }
}