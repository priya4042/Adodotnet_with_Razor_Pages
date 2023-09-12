using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1_MVC_Cnt_CITY_RES.Data;

namespace WebApplication1_MVC_Cnt_CITY_RES.Controllers
{
    public class RegisterController : Controller
    {
        private readonly RegisterDbContext DbContext;
        public RegisterController()
        {
            DbContext = new RegisterDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            DbContext.Dispose();
        }
        // GET: Register
        public ActionResult Index()
        {
            var RegisterIndex = DbContext.Registers.Include(r => r.City).Include(r => r.City.State).Include(r => r.City.State.Country).ToList();
            return View(RegisterIndex);
        }
    }
}