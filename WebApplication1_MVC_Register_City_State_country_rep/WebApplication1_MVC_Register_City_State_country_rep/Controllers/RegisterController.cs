using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1_MVC_Register_City_State_country_rep.Data;

namespace WebApplication1_MVC_Register_City_State_country_rep.Controllers
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
            var RegisterIndex= dbContext.Reistrations.Include(r=>r.City.)
            return View();
        }
    }
}