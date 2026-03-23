
using RestaurantProject.Models.Entities;

namespace RestaurantProject.Services
{
    public interface IProductService
    {
       List<Product> GetAll();
        Product? GetById(int id);
        void Add(Product product);
        void Update(int id, Product product);
        void Delete(int id);
    }
}
