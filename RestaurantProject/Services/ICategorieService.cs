using RestaurantProject.Models.Entities;

namespace RestaurantProject.Services
{
    public interface ICategoryService 
    {
        List<Category> GetAll();
        Category? GetById(int id);
        void Add(Category category);
        void Update(int id, Category category);
        void Delete(int id);
    }
}
