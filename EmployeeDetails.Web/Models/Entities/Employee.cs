namespace EmployeeDetails.Web.Models.Entities
{
    public class Employee
    {
        
        public Guid Id { get; set; }
        public int EmployeeId { get; set; }
        
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }
        public string Address { get; set; }

    }

}
