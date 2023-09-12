using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1_Mvc_Upsert_Save.Data;
using WebApplication1_Mvc_Upsert_Save.Models;

namespace WebApplication1_Mvc_Upsert_Save.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeDbContext context;
        public EmployeeController()
        {
            context = new EmployeDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
        }
        // GET: Employee
        public ActionResult Index()
        {

            return View(context.Employees.ToList());
        }
        public ActionResult Upsert(int? id)
        {
            //Create
            Employee employee = new Employee();
            if (id == null)

                return View(employee);

            else

                employee = context.Employees.Find(id);
                    if (employee == null)
                    return HttpNotFound();
            
            return View(employee);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Upsert(Employee employee)
        {
            if (employee == null)
                return HttpNotFound();
            if (!ModelState.IsValid)
                return View(employee);
            if (employee.Id == 0)
                context.Employees.Add(employee);
            else
            {
                var employeefromDb = context.Employees.Find(employee.Id);
                employeefromDb.Name = employee.Name;
                employeefromDb.Address = employee.Address;
                employeefromDb.Salary = employee.Salary;

            }
            context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        public ActionResult Delete(int id)
        {
            var employeefromDb = context.Employees.Find(id);
            if (employeefromDb == null)
                return HttpNotFound();
            context.Employees.Remove(employeefromDb);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            var employeefromdb = context.Employees.Find(id);
            if (employeefromdb == null)
                return HttpNotFound();
            return View(employeefromdb);
        }
    }
}