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
    public class MealsController : Controller
    {
        private readonly TedorderContext _context;
        IWebHostEnvironment _env;
        public MealsController(TedorderContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Cartlist(string Name)
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
            if (HttpContext.Session.GetString("ShoppingCart_N") != null)
            {
                List<string> N = HttpContext.Session.GetString("ShoppingCart_N").Split(',').ToList();
                //List<string> P = HttpContext.Session.GetString("ShoppingCart_P").Split(',').ToList();
                //List<Cart> cartList = Session["ShoppingCart"] as List<Cart>;
                List<Cart> carts = new List<Cart>();
                List<Meal> meals = new List<Meal>();
                int total= 0;
                for (int i = 0; i < N.Count; i++)
                {
                    meals.Add(await _context.Meals.SingleOrDefaultAsync(s => s.M_Name == N[i]));
                }
                for (int i = 0; i < meals.Count; i++)
                {

                    Cart cart = new Cart()
                    {
                        MealsName = meals[i].M_Name,
                        Meals_Price = int.Parse(meals[i].M_Price),
                        Meals_Count=1
                    };

                    carts.Add(cart);

                    int p = int.Parse(meals[i].M_Price);
                    total += p;
                }
                ViewBag.TOTAL = total;
                //Repeater1.DataSource = cartList;
                //Repeater1.DataBind();

                //Label1.Text = cartList.Sum(c => c.Total).ToString();
                    ViewBag.Name = Name;
                    return View(carts);
            }
            else
            {
                return RedirectToAction("IndexCustomers", "Meals");
            }

            
        }
        //public async Task<IActionResult> Total()
        //{
        //    Meal meal = await _context.Meals.SingleOrDefaultAsync(n => n.M_Name == name);
        //    Cart cart = new Cart()
        //    {

        //        MealsName = meal.M_Name,
        //        Meals_Price = int.Parse(meal.M_Price),
        //        Meals_Count = 1
        //    };


        //    if (HttpContext.Session.GetString("ShoppingCart_N") != null && HttpContext.Session.GetString("ShoppingCart_P") != null)
        //    {
        //        List<string> N = HttpContext.Session.GetString("ShoppingCart_N").Split(',').ToList();
        //        List<string> P = HttpContext.Session.GetString("ShoppingCart_P").Split(',').ToList();
        //        N.Add(meal.M_Name);
        //        P.Add(meal.M_Price);
        //        string n = string.Join(",", N);
        //        string p = string.Join(",", P);
        //        HttpContext.Session.SetString("ShoppingCart_N", n);
        //        HttpContext.Session.SetString("ShoppingCart_P", p);
        //    }
        //    else
        //    {
        //        HttpContext.Session.SetString("ShoppingCart_N", meal.M_Name);
        //        HttpContext.Session.SetString("ShoppingCart_P", meal.M_Price);
        //    }

        //    return Json(meal);
        //}

        public async Task<IActionResult> myAddCart(string name)
        {
            Meal meal = await _context.Meals.SingleOrDefaultAsync(n => n.M_Name == name);
            Cart cart = new Cart()
            {

                MealsName = meal.M_Name,
                Meals_Price = int.Parse(meal.M_Price),
                Meals_Count = 1
            };


            if (HttpContext.Session.GetString("ShoppingCart_N") != null && HttpContext.Session.GetString("ShoppingCart_P") != null)
            {
                List<string> N = HttpContext.Session.GetString("ShoppingCart_N").Split(',').ToList();
                List<string> P = HttpContext.Session.GetString("ShoppingCart_P").Split(',').ToList();
                N.Add(meal.M_Name);
                P.Add(meal.M_Price);
                string n = string.Join(",", N);
                string p = string.Join(",", P);
                HttpContext.Session.SetString("ShoppingCart_N", n);
                HttpContext.Session.SetString("ShoppingCart_P", p);
            }
            else
            {
                HttpContext.Session.SetString("ShoppingCart_N", meal.M_Name);
                HttpContext.Session.SetString("ShoppingCart_P", meal.M_Price);
            }

            return Json(meal);
        }


        // Add Cart
        [HttpPost]
        public async Task<IActionResult> AddCart(string Name)
        {
            Meal meal = await _context.Meals.SingleOrDefaultAsync(n => n.M_Name == Name);
            Cart cart = new Cart() {
                
                MealsName = meal.M_Name,
                Meals_Price= int.Parse(meal.M_Price),
                Meals_Count=1
            };
            

            if (HttpContext.Session.GetString("ShoppingCart_N") != null && HttpContext.Session.GetString("ShoppingCart_P") != null)
            {
                List<string> N = HttpContext.Session.GetString("ShoppingCart_N").Split(',').ToList();
                List<string> P = HttpContext.Session.GetString("ShoppingCart_P").Split(',').ToList();
                N.Add(meal.M_Name);
                P.Add(meal.M_Price);
                string n = string.Join(",", N);
                string p = string.Join(",", P);
                HttpContext.Session.SetString("ShoppingCart_N", n);
                HttpContext.Session.SetString("ShoppingCart_P", p);

            }
            else
            {
                HttpContext.Session.SetString("ShoppingCart_N",meal.M_Name);
                HttpContext.Session.SetString("ShoppingCart_P",meal.M_Price);
                //cartList_N = HttpContext.Session.GetString("ShoppingCart_N");
                //cartList_P = HttpContext.Session.GetString("ShoppingCart_P");
            }
            
            //cartList_N= HttpContext.Session.GetString("ShoppingCart_N"); 
            //cartList_P= HttpContext.Session.GetString("ShoppingCart_P");

            return RedirectToAction("IndexCustomers","Meals");
        }
        // GET: Meals

        public async Task<IActionResult> Index(string Name)
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

            ViewBag.Name = Name;
            return View(await _context.Meals.Where(s => s.R_Name == Name).ToListAsync());
        }
        public async Task<IActionResult> IndexCustomers(string Name)
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

            ViewBag.Name = Name;
            return View(await _context.Meals.Where(s => s.R_Name == Name).ToListAsync());
        }

        // GET: Meals/Details/5
        public async Task<IActionResult> Details(int? id ,string Name)
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

            var meal = await _context.Meals
                .FirstOrDefaultAsync(m => m.MID == id);
            if (meal == null)
            {
                return NotFound();
            }
            ViewBag.Name = Name;
            return View(meal);
        }
        public async Task<IActionResult> DetailsCustomers(int? id, string Name)
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

            var meal = await _context.Meals
                .FirstOrDefaultAsync(m => m.MID == id);
            if (meal == null)
            {
                return NotFound();
            }
            ViewBag.Name = Name;
            return View(meal);
        }

        // GET: Meals/Create
        public IActionResult Create(string Name)
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
            
            ViewBag.Name = Name;
            return View();
        }

        // POST: Meals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MID,R_Name,M_Name,M_InFo,M_Price,M_ImgFile")] Meal meal, IFormFile file)
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
                meal.M_ImgFile = file.FileName;
                var filePath = $"{_env.ContentRootPath}\\images\\Meal\\{file.FileName}";

                using (var stream = System.IO.File.Create(filePath))
                {
                    file.CopyTo(stream);
                }
                _context.Add(meal);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index","Restaurants");
            }
            return View(meal);
        }

        // GET: Meals/Edit/5
        public async Task<IActionResult> Edit(int? id ,string Name)
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
            if (id == null)
            {
                return NotFound();
            }

            var meal = await _context.Meals.FindAsync(id);
            if (meal == null)
            {
                return NotFound();
            }
            ViewBag.Name = Name;
            return View(meal);
        }

        // POST: Meals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MID,R_Name,M_Name,M_InFo,M_Price,M_ImgFile")] Meal meal)
        {
            if (id != meal.MID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(meal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MealExists(meal.MID))
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
            return View(meal);
        }

        // GET: Meals/Delete/5
        public async Task<IActionResult> Delete(int? id , string Name)
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

            var meal = await _context.Meals
                .FirstOrDefaultAsync(m => m.MID == id);
            if (meal == null)
            {
                return NotFound();
            }
            ViewBag.Name = Name;
            return View(meal);
        }

        // POST: Meals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var meal = await _context.Meals.FindAsync(id);
            _context.Meals.Remove(meal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MealExists(int id)
        {
            return _context.Meals.Any(e => e.MID == id);
        }
    }
}
