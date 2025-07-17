using Microsoft.EntityFrameworkCore;
using ProductsApi.Models;

namespace ProductsApi.Data
{
    public class AppDbContext : DbContext
    {

      public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Products> Products { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
      
       
        
        
    }
}
