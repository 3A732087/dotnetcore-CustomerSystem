using dotnetcore_CustomerSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnetcore_CustomerSystem.Controllers
{
    public class CustomerController : Controller
    {
        CustomerSystemContext db = new CustomerSystemContext();

        public IActionResult Index()
        {
            var customers = db.Customer.ToList();
            return View(customers);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            db.Customer.Add(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
