using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RestaurantProject.Data;
using RestaurantProject.Models.Entities;
using System.Data;
using System.Threading.Tasks;

namespace RestaurantProject.Services
{
    public class ProductService(RestaurantDbContext context, ILogger<ProductService> logger) : IProductService
    {
        private readonly RestaurantDbContext context = context;
        private readonly ILogger<ProductService> logger = logger;
        public async Task Add(Product product)
        {
            
            await context.Products.AddAsync(product);   
            await context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            await context.Baskets.ExecuteDeleteAsync();
            await context.SaveChangesAsync();
        }

        public async Task<List<Product>>GetAllAsync()
        {
            logger.LogInformation("Get products from database");

            return await context.Products.ToListAsync();
        }

        public async Task<Product?> GetById(int id)
        {
            return await context.Products.Where(c => c.Id == id).FirstOrDefaultAsync();
        }

        public async Task Update(int id, Product product)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));

            try
            {
                var existingProduct = await context.Products.FindAsync(id);
                if (existingProduct == null) throw new KeyNotFoundException($"Product id not found.");

                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;

                await context.SaveChangesAsync();
            }
            catch (DBConcurrencyException ex)
            {
                logger.LogError(ex, $"Error updating product id");
                throw;
            }
        }

        Product? IProductService.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
