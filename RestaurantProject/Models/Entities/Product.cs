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

        public bool Nuts { get; set; }  

        public int CategoryId { get; set; }

        public int Spiciness { get; set; }  = 0;
        
        public bool Vegetarian { get; set; }

        public required string Image { get; set; }   
    }
}
