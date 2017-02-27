﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customers = new List<Customer>()
            {
                new Customer() {Id=1,Name="John Watson" },
                new Customer() {Id=2,Name="Sherlock Holm" }
            };

            var cust = new Customer() {Name = "Customer Name 1"};
            //ViewData.Model = customers;
            return View(customers);
        }
    }
}