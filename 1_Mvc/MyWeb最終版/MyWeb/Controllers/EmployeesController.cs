using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyWeb.Data;
using MyWeb.Models;

namespace MyWeb.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly TedorderContext _context;

        public EmployeesController(TedorderContext context)
        {
            _context = context;
        }

        // GET: Employees
        public async Task<IActionResult> Index()
        {
            ViewBag.IsLogin = HttpContext.Session.GetString("LoginEmail") != null;
            if (ViewBag.IsLogin)
            {

                string Email = HttpContext.Session.GetString("LoginEmail");
                Employee employee = await _context.Employees.SingleOrDefaultAsync(s => s.E_Email == Email);
                if (employee != null)
                {
                    ViewBag.E_Name ="管理員"+ employee.E_Name;
                }

            }
            return View(await _context.Employees.ToListAsync());
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            ViewBag.IsLogin = HttpContext.Session.GetString("LoginEmail") != null;
            if (ViewBag.IsLogin)
            {

                string Email = HttpContext.Session.GetString("LoginEmail");
                Employee employee1 = await _context.Employees.SingleOrDefaultAsync(s => s.E_Email == Email);
                if (employee1 != null)
                {
                    ViewBag.E_Name = "管理員" + employee1.E_Name;
                }

            }
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.EmployeeID == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employees/Create
        public IActionResult Create()
        {
            ViewBag.IsLogin = HttpContext.Session.GetString("LoginEmail") != null;
            if (ViewBag.IsLogin)
            {

                string Email = HttpContext.Session.GetString("LoginEmail");
                Employee employee1 = _context.Employees.SingleOrDefault(s => s.E_Email == Email);
                if (employee1 != null)
                {
                    ViewBag.E_Name = "管理員" + employee1.E_Name;
                }

            }
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeID,E_Name,E_Account,E_Password,E_Phone,E_Email")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.IsLogin = HttpContext.Session.GetString("LoginEmail") != null;
            if (ViewBag.IsLogin)
            {

                string Email = HttpContext.Session.GetString("LoginEmail");
                Employee employee1 = await _context.Employees.SingleOrDefaultAsync(s => s.E_Email == Email);
                if (employee1 != null)
                {
                    ViewBag.E_Name = "管理員" + employee1.E_Name;
                }

            }
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmployeeID,E_Name,E_Account,E_Password,E_Phone,E_Email")] Employee employee)
        {
            if (id != employee.EmployeeID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.EmployeeID))
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
            return View(employee);
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            ViewBag.IsLogin = HttpContext.Session.GetString("LoginEmail") != null;
            if (ViewBag.IsLogin)
            {

                string Email = HttpContext.Session.GetString("LoginEmail");
                Employee employee1 = await _context.Employees.SingleOrDefaultAsync(s => s.E_Email == Email);
                if (employee1 != null)
                {
                    ViewBag.E_Name = "管理員" + employee1.E_Name;
                }

            }
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .FirstOrDefaultAsync(m => m.EmployeeID == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.EmployeeID == id);
        }
    }
}
