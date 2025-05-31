using Application.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly string _jwtKey;
        public AuthenticationService(IConfiguration configuration)
        {
            _jwtKey = configuration["Jwt:Key"]!;
        }

        public bool ValidateUser(string username, string password)
        {            
            return username == "user" && password == "123456";
        }

        public string GenerateJwtToken(string username)
        {
            var keyBytes = Encoding.UTF8.GetBytes(_jwtKey);
            var claims = new[]
            {
            new Claim(ClaimTypes.Name, username)
        };

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(keyBytes), SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
