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
        public DbSet<Category> Categories { get; set; }
        public DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                Id = 1,
                Name = "Fast Food",
                ImageUrl = "https://www.google.com"
            },
                new Category
                {
                Id = 2,
                Name = "Italian",
                ImageUrl = "https://www.google.com"
            },
              new Category
                {
                Id = 3,
                Name = "Mexican",
                ImageUrl = "https://www.google.com"
            });

            modelBuilder.Entity<Menu>().HasData(
            new Menu
            {
                Id = 1,
                Name = "Pizza",
                Description = "Cheese Pizza",
                Price = 10.00,
                CategoryId = 2,
                ImageUrl = "https://www.google.com"
            },
            new Menu
            {
                Id = 2,
                Name = "Burger",
                Description = "Cheese Burger",
                Price = 5.00,
                CategoryId = 1,
                ImageUrl = "https://www.google.com"
            },
            new Menu
            {
                Id = 3,
                Name = "Pasta",
                Description = "Cheese Pasta",
                Price = 8.00,
                CategoryId = 2,
                ImageUrl = "https://www.google.com"
            }
            );

            modelBuilder.Entity<Reservation>().HasData(

                new Reservation
                {
                    Id = 1,
                    CustomerName = "John Doe",
                    PhoneNumber = "1234567890",
                    Email = "john.doe@test.com",
                    PartySize = 4,
                    SpecialRequest = "Near the window",
                    ReservationDate = new System.DateTime(2024, 6, 20, 18, 0, 0),
                },
                new Reservation
                {
                    Id = 2,
                    CustomerName = "Max Mann",
                    PhoneNumber = "02222333",
                    Email = "max1@mann.com",
                    PartySize = 30,
                    SpecialRequest = "Double Table",
                    ReservationDate = new System.DateTime(2024, 7, 10, 18, 0, 0),
                }

                );
        }
    }
}
