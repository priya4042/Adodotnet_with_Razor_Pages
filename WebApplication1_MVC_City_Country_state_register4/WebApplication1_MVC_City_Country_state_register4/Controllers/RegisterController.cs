using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1_MVC_City_Country_state_register4.Data;
using WebApplication1_MVC_City_Country_state_register4.Models;

namespace WebApplication1_MVC_City_Country_state_register4.Controllers
{
    public class RegisterController : Controller
    {
        private readonly RegisterDbContext dbContext;

        public RegisterController()
        {
            dbContext = new RegisterDbContext();       
        }

        protected override void Dispose(bool disposing)
        {
            dbContext.Dispose();
        }
        // GET: Register
        public ActionResult Index()
        {
            var RegisterList = dbContext.Registers.Include(r => r.City).Include(r => r.City.State).Include(r => r.City.State.Country).ToList();
            return View(RegisterList);
        }

        public ActionResult Create()
        {
            ViewBag.CountryList = dbContext.Registers.ToList();
            ViewBag.StateList = dbContext.Registers.ToList();
            ViewBag.CityList = dbContext.Registers.ToList();
            Register register = new Register();
            return View(register)
        }
    }
}