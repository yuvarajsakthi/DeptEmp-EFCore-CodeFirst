using Microsoft.EntityFrameworkCore;

namespace DeptEmp.Models
{
    public class DeptEmpContext : DbContext
    {
        public DeptEmpContext(DbContextOptions<DeptEmpContext> options) : base(options) { }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source= YUVARAJ; database= DeptEmpEFCodeFirst; integrated security= true; trustservercertificate= true;");
        }
    }
}
