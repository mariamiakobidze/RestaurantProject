using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantProject.Models.Entities
{
    public class Basket
    {
        public int Id { get; set; }

        [Column("productId")]
        public int ProductId { get; set; }
        
        public int quantity { get; set; }

        public int price { get; set; }
    }
}
