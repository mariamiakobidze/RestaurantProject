using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RestaurantProject.Models.Entities;

namespace RestaurantProject.Data
{
    public class RestaurantDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, Guid>
    {
        public RestaurantDbContext(DbContextOptions options) : base(options) { }

        public RestaurantDbContext()
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
                new Product() { Id = 1, Name = "Laab Kai Chicken Salad", Price = 10, Nuts = true, Image = "", CategoryId = 1 },
                new Product() { Id = 2, Name = "Tom Yum Soup", Price = 8, Nuts = false, Image = "", CategoryId = 2 },
                new Product() { Id = 3, Name = "Grilled Chicken Breast", Price = 15, Nuts = false, Image = "", CategoryId = 3 },
                new Product() { Id = 4, Name = "Beef Stroganoff", Price = 18, Nuts = false, Image = "", CategoryId = 4 },
                new Product() { Id = 5, Name = "Garlic Butter Shrimp", Price = 20, Nuts = false, Image = "", CategoryId = 5 },
                new Product() { Id = 6, Name = "Stir-Fried Vegetables", Price = 9, Nuts = false, Image = "", CategoryId = 6 },
                new Product() { Id = 7, Name = "Spring Rolls", Price = 6, Nuts = false, Image = "", CategoryId = 7 },
                new Product() { Id = 8, Name = "French Fries", Price = 5, Nuts = false, Image = "", CategoryId = 8 }
            );
        }
    }
}