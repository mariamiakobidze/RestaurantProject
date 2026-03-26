using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantProject.Models.Entities
{
    public class Product
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        [Required(ErrorMessage = "Name is required")]
        public required string Name { get; set; } = null!;

        [Required(ErrorMessage = "Price can not be blank")]
        [Column("price", TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }

        [Column("nuts")]
        public bool Nuts { get; set; }

        [Column("categoryId")]
        public int CategoryId { get; set; } = 0;

        [Column("spiciness")]
        public int Spiciness { get; set; } = 0;

        public bool Vegetarian { get; set; }

        [Column("image")]
        [Required(ErrorMessage = "Image is required")]
        public required string Image { get; set; }
    }
}
