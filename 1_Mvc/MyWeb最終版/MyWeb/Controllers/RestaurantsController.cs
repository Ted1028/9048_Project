using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyWeb.Data;
using MyWeb.Models;

namespace MyWeb.Controllers
{
    public class RestaurantsController : Controller
    {
        private readonly TedorderContext _context;
        IWebHostEnvironment _env;

       
        public RestaurantsController(TedorderContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        // GET: Restaurants
        public async Task<IActionResult> Index()
        {
            ViewBag.IsLogin = HttpContext.Session.GetString("LoginEmail") != null;
            if (ViewBag.IsLogin)
            {

                string Email =  HttpContext.Session.GetString("LoginEmail");
                Employee employee = await _context.Employees.SingleOrDefaultAsync(s => s.E_Email == Email);
                if (employee!=null)
                {
                    ViewBag.E_Name ="管理員"+ employee.E_Name;
                }

            }
            return View(await _context.Restaurants.ToListAsync());
        }
        public async Task<IActionResult> IndexCustomers()
        {
            ViewBag.IsLogin = HttpContext.Session.GetString("LoginEmail") != null;
            if (ViewBag.IsLogin)
            {

                string Email = HttpContext.Session.GetString("LoginEmail");
                Customer customer = await _context.Customers.SingleOrDefaultAsync(s => s.C_AC_Email == Email);
                if (customer != null)
                {
                    ViewBag.E_Name ="會員"+ customer.C_Name;
                }

            }
            return View(await _context.Restaurants.ToListAsync());
        }
        //public async Task<IActionResult> IndexCustomers(string Name)
        //{
        //    ViewBag.IsLogin = HttpContext.Session.GetString("LoginEmail") != null;
        //    if (ViewBag.IsLogin)
        //    {

        //        string Email = HttpContext.Session.GetString("LoginEmail");
        //        Customer customer = await _context.Customers.SingleOrDefaultAsync(s => s.C_AC_Email == Email);
        //        if (customer != null)
        //        {
        //            ViewBag.E_Name = "會員" + customer.C_Name;
        //        }

        //    }
        //    ViewBag.Name = Name;
        //    return View(await _context.Restaurants.Where(s=>s.RestaurantName.Contains(Name)).ToListAsync());
        //}

        // GET: Restaurants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            ViewBag.IsLogin = HttpContext.Session.GetString("LoginEmail") != null;
            if (ViewBag.IsLogin)
            {

                string Email = HttpContext.Session.GetString("LoginEmail");
                Employee employee = await _context.Employees.SingleOrDefaultAsync(s => s.E_Email == Email);
                if (employee != null)
                {
                    ViewBag.E_Name = "管理員" + employee.E_Name;
                }

            }
            if (id == null)
            {
                return NotFound();
            }

            var restaurant = await _context.Restaurants
                .FirstOrDefaultAsync(m => m.RID == id);
            if (restaurant == null)
            {
                return NotFound();
            }

            return View(restaurant);
        }
        public async Task<IActionResult> DetailsCustomers(int? id)
        {
            ViewBag.IsLogin = HttpContext.Session.GetString("LoginEmail") != null;
            if (ViewBag.IsLogin)
            {

                string Email = HttpContext.Session.GetString("LoginEmail");
                Customer customer = await _context.Customers.SingleOrDefaultAsync(s => s.C_AC_Email == Email);
                if (customer != null)
                {
                    ViewBag.E_Name = "會員" + customer.C_Name;
                }

            }
            if (id == null)
            {
                return NotFound();
            }

            var restaurant = await _context.Restaurants
                .FirstOrDefaultAsync(m => m.RID == id);
            if (restaurant == null)
            {
                return NotFound();
            }

            return View(restaurant);
        }

        // GET: Restaurants/Create
        public IActionResult Create()
        {
            ViewBag.IsLogin = HttpContext.Session.GetString("LoginEmail") != null;
            if (ViewBag.IsLogin)
            {

                string Email = HttpContext.Session.GetString("LoginEmail");
                Employee employee =  _context.Employees.SingleOrDefault(s => s.E_Email == Email);
                if (employee != null)
                {
                    ViewBag.E_Name = "管理員" + employee.E_Name;
                }

            }
            return View();
        }
        

        // POST: Restaurants/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RID,RestaurantName,R_Phone,R_Address,R_Contact,R_C_Cellphone,R_ImgFile")] Restaurant restaurant, IFormFile file)
        {
            ViewBag.IsLogin = HttpContext.Session.GetString("LoginEmail") != null;
            if (ViewBag.IsLogin)
            {

                string Email = HttpContext.Session.GetString("LoginEmail");
                Employee employee = _context.Employees.SingleOrDefault(s => s.E_Email == Email);
                if (employee != null)
                {
                    ViewBag.E_Name = "管理員" + employee.E_Name;
                }

            }
            if (ModelState.IsValid)
            {
                restaurant.R_ImgFile = file.FileName;
                var filePath = $"{_env.ContentRootPath}\\images\\Rest\\{file.FileName}";

                using (var stream = System.IO.File.Create(filePath))
                {
                    file.CopyTo(stream);
                }
                _context.Add(restaurant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(restaurant);
        }

        // GET: Restaurants/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.IsLogin = HttpContext.Session.GetString("LoginEmail") != null;
            if (ViewBag.IsLogin)
            {

                string Email = HttpContext.Session.GetString("LoginEmail");
                Employee employee = await _context.Employees.SingleOrDefaultAsync(s => s.E_Email == Email);
                if (employee != null)
                {
                    ViewBag.E_Name = "管理員" + employee.E_Name;
                }

            }
            if (id == null)
            {
                return NotFound();
            }

            var restaurant = await _context.Restaurants.FindAsync(id);
            if (restaurant == null)
            {
                return NotFound();
            }
            return View(restaurant);
        }

        // POST: Restaurants/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RID,RestaurantName,R_Phone,R_Address,R_Contact,R_C_Cellphone,R_ImgFile")] Restaurant restaurant)
        {
            if (id != restaurant.RID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(restaurant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RestaurantExists(restaurant.RID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(restaurant);
        }

        // GET: Restaurants/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            ViewBag.IsLogin = HttpContext.Session.GetString("LoginEmail") != null;
            if (ViewBag.IsLogin)
            {

                string Email = HttpContext.Session.GetString("LoginEmail");
                Employee employee = _context.Employees.SingleOrDefault(s => s.E_Email == Email);
                if (employee != null)
                {
                    ViewBag.E_Name = "管理員" + employee.E_Name;
                }

            }
            if (id == null)
            {
                return NotFound();
            }

            var restaurant = await _context.Restaurants
                .FirstOrDefaultAsync(m => m.RID == id);
            if (restaurant == null)
            {
                return NotFound();
            }

            return View(restaurant);
        }

        // POST: Restaurants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var restaurant = await _context.Restaurants.FindAsync(id);
            _context.Restaurants.Remove(restaurant);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RestaurantExists(int id)
        {
            return _context.Restaurants.Any(e => e.RID == id);
        }
    }
}
