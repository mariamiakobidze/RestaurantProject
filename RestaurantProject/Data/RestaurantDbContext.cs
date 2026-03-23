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
    }
}
