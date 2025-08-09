using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeptEmp.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string? FullName { get; set; }
        public string? Position { get; set; }
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public Department? Department { get; set; }
    }
}
