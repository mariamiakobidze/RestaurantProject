using System.ComponentModel.DataAnnotations;

namespace RestaurantProject.Models.DTOs
{
    public class LoginDto
    {
        [Required(ErrorMessage = "Email can't be blank")]
        [EmailAddress(ErrorMessage = "Email should be proper email address format")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password can't be blank")]
        public string Password { get; set; }
    }
}
