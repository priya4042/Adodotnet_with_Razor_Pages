using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1_MVC_Register_City_Country_State.Data;

namespace WebApplication1_MVC_Register_City_Country_State.Controllers
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
            var RegisterIndex = dbContext.Registers.Include(r => r.cit)
            return View();
        }
    }
}