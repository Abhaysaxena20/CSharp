using Microsoft.EntityFrameworkCore;
using WebApplication1.ViewModel;

namespace WebApplication1.Models
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext (DbContextOptions<ApplicationContext> options) : base(options) { }
        public DbSet<UserEmployees> UserEmployees { get; set; }
    }
}
