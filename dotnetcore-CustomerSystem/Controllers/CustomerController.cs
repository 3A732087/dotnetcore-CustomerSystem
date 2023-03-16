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
    }
}
