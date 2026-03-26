using RestaurantProject.Models.Entities;

namespace RestaurantProject.Services
{
    /// <summary>
    /// Service interface for managing product categories.
    /// </summary>
    public interface ICategoryService
    {
        /// <summary>
        /// Retrieves all categories.
        /// </summary>
        /// <returns>A list of <see cref="Category"/> objects.</returns>
        Task<List<Category>> GetAll();

        /// <summary>
        /// Retrieves a category by its ID.
        /// </summary>
        /// <param name="id">The ID of the category to retrieve.</param>
        /// <returns>The <see cref="Category"/> if found; otherwise, <c>null</c>.</returns>
        Task<Category?> GetById(int id);

        /// <summary>
        /// Adds a new category.
        /// </summary>
        /// <param name="category">The <see cref="Category"/> to add.</param>
        Task Add(Category category);

        /// <summary>
        /// Updates an existing category by its ID.
        /// </summary>
        /// <param name="id">The ID of the category to update.</param>
        /// <param name="category">The updated <see cref="Category"/> data.</param>
        Task Update(int id, Category category);

        /// <summary>
        /// Deletes a category by its ID.
        /// </summary>
        /// <param name="id">The ID of the category to delete.</param>
        Task Delete(int id);
    }
}
