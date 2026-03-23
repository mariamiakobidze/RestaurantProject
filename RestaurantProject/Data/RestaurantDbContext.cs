using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


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

        //
    }
}
