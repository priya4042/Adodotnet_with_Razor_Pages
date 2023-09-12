using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1_MVC_country_city_state_5.Data;

namespace WebApplication1_MVC_country_city_state_5.Controllers
{
    public class RegisterController : Controller
    {
        private readonly RegistrationDbContext dbContext;
            public RegisterController()
        {
            dbContext = new RegistrationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            dbContext.Dispose();
        }

        // GET: Register
        public ActionResult Index()
        {
            var RegisterList = dbContext.Registers.ToList();
            return View(RegisterList);
        }
    }
}