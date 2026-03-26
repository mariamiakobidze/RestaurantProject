using Microsoft.EntityFrameworkCore;
using RestaurantProject.Data;
using RestaurantProject.Models.Entities;
using System.Data;
using System.Threading.Tasks;

namespace RestaurantProject.Services
{
    public class CategoryService(RestaurantDbContext context, ILogger<CategoryService> logger) : ICategoryService
    {
        private readonly ILogger<CategoryService> logger = logger;
        private readonly RestaurantDbContext context = context;

        public async Task Add(Category category)
        {

            await context.AddAsync(category);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            await context.Categories.Where(c => c.Id == id).ExecuteDeleteAsync();
            await context.SaveChangesAsync();
        }

        public async Task<List<Category>> GetAll()
        {
            return await context.Categories.ToListAsync();
        }

        public async Task<Category?> GetById(int id)
        {
            return await context.Categories.Where(c => c.Id == id).FirstOrDefaultAsync();

        }

        public async Task Update(int id, Category category)
        {
            if (category == null) throw new ArgumentNullException(nameof(category));

            try
            {
                await context.Categories
                    .Where(c => c.Id == id)
                    .ExecuteUpdateAsync(c => c.SetProperty(p => p.Name, category.Name));

                await context.SaveChangesAsync();
            }
            catch (DBConcurrencyException ex)
            {
                logger.LogError(ex, $"Error updating category id");
                throw;
            }
        }
    }
}
