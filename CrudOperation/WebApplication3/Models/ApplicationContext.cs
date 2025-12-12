using Microsoft.EntityFrameworkCore;

namespace WebApplication3.Models
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<Employee> Employees { get; set; }

    }
}
