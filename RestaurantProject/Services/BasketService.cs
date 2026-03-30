using Microsoft.EntityFrameworkCore;
using RestaurantProject.Data;
using RestaurantProject.Models.Entities;

namespace RestaurantProject.Services
{
    public class BasketService(RestaurantDbContext context) : IBasketService
    {
        private readonly RestaurantDbContext context = context;

        public async Task Add(Basket item)
        {
            await context.Baskets.AddAsync(item);
            await context.SaveChangesAsync();
        }

        public async Task Clear()
        {
            await context.Baskets.ExecuteDeleteAsync();
        }

        public async Task<List<Basket>> GetAll()
        {
            return await context.Baskets.ToListAsync();
        }

        public async Task Remove(int productId)
        {
            await context.Baskets.Where(b => b.ProductId == productId).ExecuteDeleteAsync();
        }
    }
}