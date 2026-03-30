using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using RestaurantProject.Models.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace RestaurantProject.Services
{
    
    public class JwtService(IConfiguration configuration, UserManager<ApplicationUser> userManager) : IJwtService
    {
        private readonly JwtOptions jwtOptions;
        private readonly IConfiguration configuration = configuration;
        private readonly UserManager<ApplicationUser> userManager = userManager;


        public AuthenticationResponse CreateJwtToken(ApplicationUser user)
        {
            if (string.IsNullOrWhiteSpace(jwtOptions.Key))
                throw new InvalidOperationException("JWT Key is not configured.");
            if (string.IsNullOrWhiteSpace(jwtOptions.Issuer))
                throw new InvalidOperationException("JWT Issuer is not configured.");
            if (string.IsNullOrWhiteSpace(jwtOptions.Audience))
                throw new InvalidOperationException("JWT Audience is not configured.");

            DateTime expiration = DateTime.UtcNow.AddMinutes(jwtOptions.ExpirationMinutes);

            Claim[] claims =
            [
                new Claim(JwtRegisteredClaimNames.Sub, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat,
                    new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds().ToString()),
                new Claim(ClaimTypes.Email, user.Email ?? string.Empty),
                new Claim(ClaimTypes.Name, user.PersonName ?? string.Empty),
            ];

            SymmetricSecurityKey securityKey = new(
                Encoding.UTF8.GetBytes(jwtOptions.Key));

            SigningCredentials credentials = new(
                securityKey, SecurityAlgorithms.HmacSha256);

            JwtSecurityToken tokenGenerator = new(
                jwtOptions.Issuer,
                jwtOptions.Audience,
                claims,
                expires: expiration,
                signingCredentials: credentials);

            string token = new JwtSecurityTokenHandler().WriteToken(tokenGenerator);

            return new AuthenticationResponse
            {
                Token = token,
                Email = user.Email,
                PersonName = user.PersonName,
                ExpirationTime = expiration
            };
        }
    }
}