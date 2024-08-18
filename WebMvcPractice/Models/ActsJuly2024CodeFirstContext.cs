using Microsoft.EntityFrameworkCore;

namespace WebMvcPractice.Models
{
    public class ActsJuly2024CodeFirstContext : DbContext
    {
        public ActsJuly2024CodeFirstContext()
        {
        }
        public ActsJuly2024CodeFirstContext(DbContextOptions<ActsJuly2024CodeFirstContext> options)
                     : base(options)
        {
        }
        public virtual DbSet<Department> Departments { get; set; }

        public virtual DbSet<Employee> Employees
        {
            get; set;
        }





    }

  
}
