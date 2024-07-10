using EmployeeDetails.Web.Data;
using EmployeeDetails.Web.Models.Entities;
using EmployeeDetails.Web.Models;
using Microsoft.AspNetCore.Mvc;

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
                var employee = new Employee
                {
                    Id= viewModel.Id,
                    Name = viewModel.Name,
                    Designation=viewModel.Designation,
                    Email = viewModel.Email,
                    Phone = viewModel.Phone,
                    Address = viewModel.Address,
                    

                };
                await dbContest.Employees.AddAsync(employee);
                await dbContest.SaveChangesAsync();
                return View();
            }
        }

        
    }
