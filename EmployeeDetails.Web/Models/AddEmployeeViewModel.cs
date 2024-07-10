using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EmployeeDetails.Web.Models
{
    public class AddEmployeeViewModel
    {
        [BindProperty]
        public string EmployeeId { get; set; }
        [BindProperty]
        [Required(ErrorMessage ="Enter name:")]
        public string Name { get; set; } = "";
        [BindProperty]
        public string Designation { get; set; } = "";
        [BindProperty]
        public string Email { get; set; } = "";
        [BindProperty]

        public string Phone { get; set; } = "";
        [BindProperty]
        public string Address { get; set; } = "";

        



    }
}
