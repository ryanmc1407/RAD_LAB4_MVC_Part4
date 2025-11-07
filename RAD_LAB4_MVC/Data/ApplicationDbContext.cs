using Microsoft.EntityFrameworkCore;
using RAD_LAB4_MVC.Models;

namespace RAD_LAB4_MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
    }
}

