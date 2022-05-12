using CoffeeRegistrationLab.Data;
using CoffeeRegistrationLab.Models;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace CoffeeRegistrationLab.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            List<Customer> customerList = _context.Customers.ToList();
            
            return View(customerList);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Welcome(int id)
        {
            var customer = _context.Customers.FirstOrDefault(x => x.Id == id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("FirstName,LastName,Email,Password")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                customer.Password = BCrypt.Net.BCrypt.HashPassword(customer.Password);
                TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
                customer.FirstName = myTI.ToTitleCase(customer.FirstName);
                customer.LastName = myTI.ToTitleCase(customer.LastName);
                _context.Add(customer);
                _context.SaveChanges();
                return RedirectToAction("Welcome", new {id = customer.Id});
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            var customer = _context.Customers.FirstOrDefault(x => x.Id == id);
            if(customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var customer = _context.Customers.FirstOrDefault(x => x.Id == id);

            _context.Customers.Remove(customer);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var customer = _context.Customers.FirstOrDefault(x=> x.Id == id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,FirstName,LastName,Email,Password")] Customer customer)
        {
            if (id != customer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(customer);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer);
        }

        public IActionResult Details(int id)
        {
            var customer = _context.Customers.FirstOrDefault(x => x.Id == id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }
    }
}
