using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using MyWeb.Data;
using MyWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeb.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        private readonly TedorderContext _context;

        public HomeController(TedorderContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.IsLogin = HttpContext.Session.GetString("LoginEmail") != null;
            if (ViewBag.IsLogin)
            {

                string Email =  HttpContext.Session.GetString("LoginEmail");
                Employee employee = await _context.Employees.SingleOrDefaultAsync(s => s.E_Email == Email);
                if (employee!=null)
                {
                    ViewBag.E_Name = employee.E_Name;
                }

            }
            return View();
        }
        public IActionResult Login()
        {
            ViewBag.IsLogin = HttpContext.Session.GetString("LoginEmail") != null;
            if (ViewBag.IsLogin)
            {

                string Email = HttpContext.Session.GetString("LoginEmail");
                Employee employee = _context.Employees.SingleOrDefault(s => s.E_Email == Email);
                if (employee != null)
                {
                    ViewBag.E_Name = employee.E_Name;
                }

            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(string E_Account, string E_Password)
        {
            Employee employee = await _context.Employees.SingleOrDefaultAsync(s => s.E_Account == E_Account && s.E_Password == E_Password);
            Customer customer = await _context.Customers.SingleOrDefaultAsync(s => s.C_AC_Email == E_Account && s.C_Password == E_Password);
            if(employee != null)
            {
                //using Microsoft.AspNetCore.Http;
                HttpContext.Session.SetString("LoginEmail", employee.E_Email);
                return RedirectToAction("Index","Restaurants");
            }
            else if (customer!=null)
            {
                HttpContext.Session.SetString("LoginEmail", customer.C_AC_Email);
                return RedirectToAction("IndexCustomers", "Restaurants");
            }
            ModelState.AddModelError("Error", "帳號或密碼不正確");
            return  View(employee);
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();

            return RedirectToAction("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
