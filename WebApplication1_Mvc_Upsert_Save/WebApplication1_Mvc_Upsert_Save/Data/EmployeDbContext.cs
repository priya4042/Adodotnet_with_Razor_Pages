using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication1_Mvc_Upsert_Save.Models;

namespace WebApplication1_Mvc_Upsert_Save.Data
{
    public class EmployeDbContext:DbContext
    {
        public EmployeDbContext():base("conStr")
        {
                
        }
        public DbSet<Employee> Employees { get; set; }
    }
}