using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Scribe.Models;

namespace Scribe.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            List<Customer> data = new List<Customer>
            {
                new Customer() {name = "ABC Company", city = "Billings", state = "Montana" },
                new Customer() {name = "Yellowstone National Park Foundation", city = "Cody", state = "Wyoming" },
                new Customer() {name = "360 Office Solutions", city = "Helena", state = "Montana"}
            };

            return View("CustomerList", data);
        }
    }
}