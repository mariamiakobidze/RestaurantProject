using RestaurantProject.Models.Entities;

namespace RestaurantProject.Services
{
    public interface IBasketService
    {
        List<Basket> GetAll();
        void Add(Basket item);
        void Remove(int productId);
        void Clear();
    }
}
