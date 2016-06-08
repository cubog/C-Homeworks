using HW4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW4.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            return View(customer);
        }
        public ActionResult Edit(int? id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            return View(customer);
        }
        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {

                new Customer { Id = 1, Name = "Douglas Rodriguez", PhoneNumber= "305-555-5955", Address = "11011 SW 104 St, Miami, FL", ZipCode = "33175" , Age = 30, Birthdate = new DateTime(1980, 6, 1, 12, 32, 30) },
                new Customer { Id = 2, Name = "Juan Gonzalez",  PhoneNumber= "786-999-5955", Address = "104 SW 107 Ave, Miami, FL", ZipCode = "33173" , Age = 20, Birthdate = new DateTime(1993, 3, 12, 12, 32, 30) }
            };
        }
    }
}