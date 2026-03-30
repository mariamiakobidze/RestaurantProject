using Microsoft.AspNetCore.Identity;
using RestaurantProject.Models.Entities;

namespace RestaurantProject.Services
{
    public interface IJwtService
    {
        AuthenticationResponse CreateJwtToken(ApplicationUser user);
    }

    public class AuthenticationResponse
    {
        public string Token { get; set; }
        public string Email { get; set; }
        public string PersonName { get; set; }
        public DateTime ExpirationTime { get; set; }
    }
}