using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RestaurantProject.Models.Entities;


namespace RestaurantProject.Data
{
    public class RestaurantDbContext : IdentityDbContext

    {
        public RestaurantDbContext(DbContextOptions options) : base(options)
        {
        }

        protected RestaurantDbContext()
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Basket> Baskets { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)

        {
            base.OnModelCreating(builder);
            builder.Entity<Category>().HasData(

                new Category() { Id = 1, Name = "Salads" },
                new Category() { Id = 2, Name = "Soups" },
                new Category() { Id = 3, Name = "Chicken-Dishes" },
                new Category() { Id = 4, Name = "Beef-Dishes" },
                new Category() { Id = 5, Name = "Seafood-Dishes" },
                new Category() { Id = 6, Name = "Vegetable-Dishes" },
                new Category() { Id = 7, Name = "Bits&Bites" },
                new Category() { Id = 8, Name = "On-The-Side" });
            builder.Entity<Product>().HasData(
                new Product() { Id = 1, Name="Laab kai chicken salad", Price = 10, Nuts= true,Image = ""}
               
                );

        }
    }
}
