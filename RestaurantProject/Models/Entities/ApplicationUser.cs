using Microsoft.AspNetCore.Identity;

namespace RestaurantProject.Models.Entities
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string? PersonName { get; set; }
    }
}
