using GraphQlPlayground.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQlPlayground.Data
{
    public class GraphQlPlaygroundDbContext : DbContext
    {
        public GraphQlPlaygroundDbContext(DbContextOptions<GraphQlPlaygroundDbContext> options) : base(options)
        {
        }

        public DbSet<Menu> Menus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Menu>().HasData(
            new Menu
            {
                Id = 1,
                Name = "Pizza",
                Description = "Cheese Pizza",
                Price = 10.00
            },
            new Menu
            {
                Id = 2,
                Name = "Burger",
                Description = "Cheese Burger",
                Price = 5.00
            },
            new Menu
            {
                Id = 3,
                Name = "Pasta",
                Description = "Cheese Pasta",
                Price = 8.00
            }
            );  
        }
    }
}
