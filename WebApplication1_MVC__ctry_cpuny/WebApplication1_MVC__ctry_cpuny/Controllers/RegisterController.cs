using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1_MVC__ctry_cpuny.Data;
using WebApplication1_MVC__ctry_cpuny.Models;

namespace WebApplication1_MVC__ctry_cpuny.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public RegisterController()
        {
            dbContext = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            dbContext.Dispose();
        }

        // GET: Register
        public ActionResult Index()
        {
            var RegisterIndex = dbContext.Registers.Include(r => r.City).Include(r => r.City.State).Include(r => r.City.State.country).ToList();
            return View(RegisterIndex);
        }

        public ActionResult Create()
        {
            ViewBag.Country = dbContext.Countries.ToList();
            ViewBag.State = dbContext.States.ToList();
            ViewBag.City = dbContext.Cities.ToList();
            Register register = new Register();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(Register register)
        {
            if (register == null)
                return HttpNotFound();
            if (!ModelState.IsValid)
            {
                ViewBag.Country = dbContext.Countries.ToList();
                ViewBag.State = dbContext.States.ToList();
                ViewBag.City = dbContext.Cities.ToList();
                return View();
            }
            dbContext.Registers.Add(register);
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public ActionResult Edit(int id)
        {
            var UserInDb = dbContext.Registers.Include(r => r.City).Include(r => r.City.State).Include(r => r.City.State).FirstOrDefault(r => r.Id == id);
            if (UserInDb == null)
                return HttpNotFound();
            ViewBag.Country = dbContext.Countries.ToList();
            ViewBag.State = dbContext.States.ToList();
            ViewBag.City = dbContext.Cities.ToList();
            UserInDb.CountryId = UserInDb.City.State.country.Id;
            UserInDb.StateId = UserInDb.City.State.Id;
            return View(UserInDb);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Edit(Register register)
        {
            if (register == null)
                return View(register);
            var userfromdb = dbContext.Registers.Find(register.Id);
            if (userfromdb == null)
                return HttpNotFound();
            if (!ModelState.IsValid)
            {
                ViewBag.Country = dbContext.Countries.ToList();
                ViewBag.State = dbContext.States.ToList();
                ViewBag.City = dbContext.Cities.ToList();
                return View();
            }
            userfromdb.Name = register.Name;
            userfromdb.Address = register.Address;
            userfromdb.Email = register.Email;
            userfromdb.gender = register.gender;
            userfromdb.Subscribe = register.Subscribe;
            userfromdb.CityId = register.CityId;
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

        public ActionResult Details(int id)
        {
            var getdetails = dbContext.Registers.Include(r => r.City).Include(r => r.City.State).Include(r => r.City.State.country).FirstOrDefault(r => r.Id == id);
            if (getdetails == null)
                return HttpNotFound();
            return View(getdetails);
        }

        public ActionResult Delete(int id)
        {
            var deletedetails = dbContext.Registers.Find(id);
            if (deletedetails==null)
                return HttpNotFound();
            dbContext.Registers.Remove(deletedetails);
            dbContext.SaveChanges();
            return RedirectToAction(nameof(Index));
    }
        #region APIs
      private List<State>GetStates(int CountryId)
        {
            return dbContext.States.Where(s => s.CountryId == CountryId).ToList();
        }

        private List<City>GetCities(int StateId)
        {
            return dbContext.Cities.Where(c => c.StateId==StateId).ToList();

        }
        public ActionResult LoadStateByCountryId(int CountryId)
        {
            var StateList = GetStates(CountryId);
            var StateListData = StateList.Select(Sl => new SelectListItem()
            {
                Text = Sl.Name,
                Value = Sl.Id.ToString()

            });
            return Json(StateListData, JsonRequestBehavior.AllowGet);

        }
        public ActionResult LoadCityByStateId(int StateId)
        {
            var CityList = GetCities(StateId);
            var CityListData = CityList.Select(Cl => new SelectListItem()
            {
                Text = Cl.Name,
                Value = Cl.Id.ToString()
            }

            );
            return Json(CityListData, JsonRequestBehavior.AllowGet);
        }
                
              
                
                
            

        }
        #endregion
    

}

