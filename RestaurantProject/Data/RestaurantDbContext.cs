using Microsoft.EntityFrameworkCore;


namespace RestaurantProject.Data
{
    public class RestaurantDbContext : DbContext  

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
