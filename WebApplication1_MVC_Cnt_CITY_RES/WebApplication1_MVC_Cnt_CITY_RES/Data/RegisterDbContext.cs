using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1_MVC_Cnt_CITY_RES.Models;

namespace WebApplication1_MVC_Cnt_CITY_RES.Data
{
    public class RegisterDbContext:DbContext
    {
        public RegisterDbContext():base("Cntrl")
        {

        }
        public DbSet<Country> Countries { get; set; }

        public DbSet<State>States { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Register> Registers { get; set; }
    }
}