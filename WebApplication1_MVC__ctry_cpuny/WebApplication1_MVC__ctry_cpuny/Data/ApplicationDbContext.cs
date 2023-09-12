using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1_MVC__ctry_cpuny.Models;

namespace WebApplication1_MVC__ctry_cpuny.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext():base("ctrSl")
        {

        }
        public DbSet<Country> Countries { get; set; }

        public DbSet<State> States { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Register> Registers { get; set; }
    }
}