using Microsoft.EntityFrameworkCore;
using RestaurantProject.Data;
using RestaurantProject.Models.Entities;
using System.Threading.Tasks;

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
            await context.SaveChangesAsync();
        }

        public async Task<List<Basket>> GetAll()
        {
            return await context.Baskets.ToListAsync();
  
        }

        public async Task Remove(int productId)
        {
            await context.Baskets.Where(b => b.ProductId == productId).ExecuteDeleteAsync();
            await context.SaveChangesAsync();
        }

        async Task IBasketService.Add(Basket item)
        {
            await context.Baskets.AddAsync(item);
            await context.SaveChangesAsync();
        }

        async Task IBasketService.Clear()
        {
           await context.Baskets.ExecuteDeleteAsync();
            await context.SaveChangesAsync();
        }

        async Task<List<Basket>> IBasketService.GetAll()
        {
            return await context.Baskets.ToListAsync();
        }

        async Task IBasketService.Remove(int productId)
        {
           await context.Baskets.Where(b => b.ProductId == productId).ExecuteDeleteAsync();
            await context.SaveChangesAsync();   
        }
    }
}
