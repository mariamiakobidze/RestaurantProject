using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantProject.Models.Entities
{
    public class Category
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = null!;
    }
}
