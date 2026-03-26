using RestaurantProject.Models.Entities;

namespace RestaurantProject.Services
{
    /// <summary>
    /// Service interface for managing the user's basket/cart.
    /// </summary>
    public interface IBasketService
    {
        /// <summary>
        /// Retrieves all items currently in the basket.
        /// </summary>
        /// <returns>A list of <see cref="Basket"/> items in the basket.</returns>
        Task<List<Basket>> GetAll();

        /// <summary>
        /// Adds a new item to the basket.
        /// </summary>
        /// <param name="item">The <see cref="Basket"/> item to add.</param>
        Task Add(Basket item);

        /// <summary>
        /// Removes an item from the basket by its product ID.
        /// </summary>
        /// <param name="productId">The ID of the product to remove.</param>
        Task Remove(int productId);

        /// <summary>
        /// Clears all items from the basket.
        /// </summary>
        Task Clear();
    }
}