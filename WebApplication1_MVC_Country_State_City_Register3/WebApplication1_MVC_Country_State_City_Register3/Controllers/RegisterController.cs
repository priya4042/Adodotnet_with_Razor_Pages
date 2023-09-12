using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1_MVC_Country_State_City_Register3.Data;
using WebApplication1_MVC_Country_State_City_Register3.Models;

namespace WebApplication1_MVC_Country_State_City_Register3.Controllers
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
        public ActionResult create()
        {
            ViewBag.CountryList = dbContext.Countries.ToList();
            ViewBag.StateList = dbContext.States.ToList();
            ViewBag.CityList = dbContext.Cities.ToList();
            Register register = new Register();
            return View(register);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(Register register)
        {
            if (register == null)
                HttpNotFound();
            if(!ModelState.IsValid)
            {
                ViewBag.CountryList = dbContext.Countries.ToList();
                ViewBag.StateList = dbContext.States.ToList();
                ViewBag.CityList = dbContext.Cities.ToList();
                return View();
            }
            dbContext.Registers.Add(register);
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Edit(int id)
        {
            var RegisterList = dbContext.Registers.Include(r => r.City).Include(r => r.City.State).Include(r => r.City.State.Country).FirstOrDefault(r => r.Id == id);
                if (RegisterList == null)
                return HttpNotFound();
            ViewBag.CountryList = dbContext.Countries.ToList();
            ViewBag.StateList = dbContext.States.ToList();
            ViewBag.CityList = dbContext.Cities.ToList();

            RegisterList.CountryId = RegisterList.City.State.Country.Id;
            RegisterList.StateId = RegisterList.City.State.Id;
            return View(RegisterList);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(Register register)
        {
            if (register == null)
                return HttpNotFound();
            var Registerlist = dbContext.Registers.Find(register.Id);
            if (Registerlist == null)
                return HttpNotFound();
            if(!ModelState.IsValid)
            {
                ViewBag.CountryList = dbContext.Countries.ToList();
                ViewBag.StateList = dbContext.States.ToList();
                ViewBag.CityList = dbContext.Cities.ToList();
                return View();
            }
            Registerlist.Name = register.Name;
            Registerlist.Address = register.Address;
            Registerlist.Email = register.Email;
            Registerlist.Gender = register.Gender;
            Registerlist.Suscribe = register.Suscribe;
            Registerlist.CityId = register.CityId;
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
         }
        public ActionResult Details(int id)
        {
            var UserIndb = dbContext.Registers.Include(r => r.City).Include(r=>r.City.State).Include(r=>r.City.State.Country).FirstOrDefault(r=>r.Id==id);
            if (UserIndb == null)
                return HttpNotFound();
            return View(UserIndb);


        }

        public ActionResult Delete(int id)
        {
            var userfromdb = dbContext.Registers.Find(id);
            if (userfromdb == null)
                return HttpNotFound();
            dbContext.Registers.Remove(userfromdb);
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}