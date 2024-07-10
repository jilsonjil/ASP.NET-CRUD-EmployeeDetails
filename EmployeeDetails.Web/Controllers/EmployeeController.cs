using EmployeeDetails.Web.Data;
using EmployeeDetails.Web.Models.Entities;
using EmployeeDetails.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDetails.Web.Controllers
{
    public class EmployeeController : Controller
    {

        private readonly ApplicationDbContext dbContest;
        public EmployeeController(ApplicationDbContext dbContext)
        {
            this.dbContest = dbContext;

        }
        [HttpGet]
        public IActionResult Add() => View();
        [HttpPost]
        public async Task<IActionResult> Add(AddEmployeeViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(viewModel);
            }
            var employee = new Employee
            {
                Name = viewModel.Name,
                Designation = viewModel.Designation,
                Email = viewModel.Email,
                Phone = viewModel.Phone,
                Address = viewModel.Address,
            };
            await dbContest.Employees.AddAsync(employee);
            await dbContest.SaveChangesAsync();
            employee.EmployeeId = $"EMP{employee.Id}";
            dbContest.Employees.Update(employee);
            await dbContest.SaveChangesAsync();
            return RedirectToAction("List", "Employee");
        }
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var employees = await dbContest.Employees.ToListAsync();
            return View(employees);
        }
        [HttpGet]

        public async Task<IActionResult> Edit(int id)
        {
            var employees = await dbContest.Employees.FindAsync(id);
            return View(employees);

        }
        [HttpPost]
        public async Task<IActionResult> Edit(Employee viewModel)
        {
            var employees = await dbContest.Employees.FindAsync(viewModel.Id);
            if (employees is not null)
            {
                employees.Name = viewModel.Name;
                employees.Email = viewModel.Email;
                employees.Phone = viewModel.Phone;
                employees.Address = viewModel.Address;
                await dbContest.SaveChangesAsync();
            }
            return RedirectToAction("List", "Employee");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var employees = await dbContest.Employees.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            if (employees is not null)
            {
                dbContest.Employees.Remove(employees);
                await dbContest.SaveChangesAsync();
            }
            return RedirectToAction("List", "Employee");
        }
    }
}
