using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StoredProcedure.DataAccess;
using StoredProcedure.Models;

namespace StoredProcedure.Controllers
{
    public class EmployeesController : Controller
    {
        DataAccess.Employee db = new DataAccess.Employee();
        // GET: Employees
        public ActionResult Index()
        {
            DataSet ds = db.GetAll();
            ViewBag.emp = ds.Tables[0];
            return View();
        }

        
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(FormCollection fc)
        {
            Employees emp = new Employees();

            emp.FirstName = fc["FirstName"];
            emp.LastName = fc["LastName"];
            emp.Gender = fc["Gender"];
            emp.Address = fc["Address"];
            emp.PhoneNumber = fc["PhoneNumber"];

            db.AddEmployee(emp);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            DataSet ds = db.GetById(id);
            ViewBag.emp = ds.Tables[0];
            return View(); 
        }
        [HttpPost]
        public ActionResult Edit(int id, FormCollection fc)
        {
            Employees emp = new Employees();
            emp.Id = id;
            emp.FirstName = fc["FirstName"];
            emp.LastName = fc["LastName"];
            emp.Gender = fc["Gender"];
            emp.Address = fc["Address"];
            emp.PhoneNumber = fc["PhoneNumber"];

            db.UpdateEmployee(emp);
            return RedirectToAction("Index");
            
        }

        public ActionResult Delete(int id)
        {
            db.DeleteEmployee(id);
            TempData["msg"] = "Deleted";
            return RedirectToAction("Index");
        }

    }
}