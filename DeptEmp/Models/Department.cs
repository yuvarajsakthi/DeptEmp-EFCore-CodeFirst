using System.ComponentModel.DataAnnotations;

namespace DeptEmp.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string? Name { get; set; }

        public IList<Employee>? Employees { get; set; }
    }
}
