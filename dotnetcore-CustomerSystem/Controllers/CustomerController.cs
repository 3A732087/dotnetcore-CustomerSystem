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

        public IActionResult Edit(int id)
        {
            var customer = db.Customer.Where(m => m.Id == id).FirstOrDefault();
            return View(customer);
        }

        [HttpPost]
        public IActionResult Edit(Customer customer)
        {
            var modify = db.Customer.Where(m => m.Id == customer.Id).FirstOrDefault();
            modify.Name = customer.Name;
            modify.Phone = customer.Phone;
            modify.Email = customer.Email;
            modify.Address = customer.Address;

            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var customer = db.Customer.Where(m => m.Id == id).FirstOrDefault();
            db.Customer.Remove(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
