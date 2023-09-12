using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1_MVC_Cntr_city_sta.Data;
using WebApplication1_MVC_Cntr_city_sta.Models;

namespace WebApplication1_MVC_Cntr_city_sta.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ApplicationDbContext DbContext;

        public RegisterController()
        {
            DbContext = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            DbContext.Dispose();
        }

        public ActionResult Index()
        {
            var RegisterIndex = DbContext.Registers.Include(r => r.City).Include(r => r.City.State).Include(r => r.City.State.Country).ToList();
            return View(RegisterIndex);
        }

        public ActionResult Create()
        {
            ViewBag.Country = DbContext.Countries.ToList();
            ViewBag.States = DbContext.States.ToList();
            ViewBag.City = DbContext.Cities.ToList();
            Register register = new Register();
            return View(register);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(Register register)
        {
            if (register == null)
                return HttpNotFound();
            
            if (!ModelState.IsValid)
            {
                ViewBag.Country = DbContext.Countries.ToList();
                ViewBag.States = DbContext.States.ToList();
                ViewBag.City = DbContext.Cities.ToList();
                return View();
            }
            DbContext.Registers.Add(register);
            DbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Edit(int id)
        {
            var UserIndb = DbContext.Registers.Include(r => r.City).Include(r => r.City.State)
                   .Include(r => r.City.State.Country).FirstOrDefault(r => r.Id == id);
                if (UserIndb == null)
                return HttpNotFound();
            ViewBag.Country = DbContext.Countries.ToList();
            ViewBag.States = DbContext.States.ToList();
            ViewBag.City = DbContext.Cities.ToList();
            return View(UserIndb);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(Register register)
        {
            if (register == null)
                return HttpNotFound();
            var userfromdb = DbContext.Registers.Find(register.Id);
            if (userfromdb == null)
                return HttpNotFound();
            if(!ModelState.IsValid)
            {
                ViewBag.Country = DbContext.Countries.ToList();
                ViewBag.States = DbContext.States.ToList();
                ViewBag.City = DbContext.Cities.ToList();
                return View();
            }
            userfromdb.Name = register.Name;
            userfromdb.Address = register.Address;
            userfromdb.Email = register.Email;
            userfromdb.Gender = register.Gender;
            userfromdb.Subscribe = register.Subscribe;
            userfromdb.CityId = register.CityId;
            DbContext.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        public ActionResult Details(int id)
        {
            var Userindb = DbContext.Registers.Include(r => r.City).Include(r => r.City.State).Include(r => r.City.State.Country).FirstOrDefault(r => r.Id == id);
            if (Userindb == null)
                return HttpNotFound();
            return View(Userindb);
        }
        public ActionResult Delete(int id)
        {
            var Userfromdb = DbContext.Registers.Find(id);
            if (Userfromdb == null)
                return HttpNotFound();
            DbContext.Registers.Remove(Userfromdb);
            DbContext.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
    }
}
       