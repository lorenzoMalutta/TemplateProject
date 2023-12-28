using BaseProject.Identity.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BaseProject.Authorization.Jwt
{
    public class JwtService
    {
        public string GenerateToken(ApplicationUser user, IList<string> roles)
        {

            var handler = new JwtSecurityTokenHandler();
            List<Claim> claims = new List<Claim>
            {
                new Claim("username", user.UserName),
                new Claim("id", user.Id),
                new Claim("email", user.Email),
            };

            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Settings.Get()));

            var signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Expires = DateTime.Now.AddHours(8),
                SigningCredentials = signingCredentials,
                Subject = new ClaimsIdentity(claims)
            };

            var token = handler.CreateToken(tokenDescriptor);

            return handler.WriteToken(token);
        }
    }
}
