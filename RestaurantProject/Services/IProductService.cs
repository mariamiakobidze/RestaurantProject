using RestaurantProject.Models.Entities;

namespace RestaurantProject.Services
{
    /// <summary>
    /// Service interface for managing products.
    /// </summary>
    public interface IProductService
    {
        /// <summary>
        /// Retrieves all products.
        /// </summary>
        /// <returns>A list of <see cref="Product"/> objects.</returns>
        Task<List<Product>> GetAllAsync();

        /// <summary>
        /// Retrieves a product by its ID.
        /// </summary>
        /// <param name="id">The ID of the product to retrieve.</param>
        /// <returns>The <see cref="Product"/> if found; otherwise, <c>null</c>.</returns>
        Product? GetById(int id);

        /// <summary>
        /// Adds a new product.
        /// </summary>
        /// <param name="product">The <see cref="Product"/> to add.</param>
        Task Add(Product product);

        /// <summary>
        /// Updates an existing product by its ID.
        /// </summary>
        /// <param name="id">The ID of the product to update.</param>
        /// <param name="product">The updated <see cref="Product"/> data.</param>
        Task Update(int id, Product product);

        /// <summary>
        /// Deletes a product by its ID.
        /// </summary>
        /// <param name="id">The ID of the product to delete.</param>
        Task Delete(int id);
    }
}