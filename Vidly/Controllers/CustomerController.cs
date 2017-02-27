using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;

        public CustomerController()     //add new constructor to create _context object on class is created
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)     //dispose _context object on the class dispose
        {
            _context.Dispose();
        }

        // GET: Customer
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList(); //Eager Loading

            var cust = new Customer() {Name = "Customer Name 1"};
            //ViewData.Model = customers;
            return View(customers);
        }


        public ActionResult Details(int? id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }

    }
}