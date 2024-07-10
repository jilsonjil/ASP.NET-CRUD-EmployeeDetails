using EmployeeDetails.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeDetails.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }

    }
}
