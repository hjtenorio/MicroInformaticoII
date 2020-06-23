using Identity.Domain.AggregatesModel.JwtTokenAggregate;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Identity.Infrastructure.Valtx.Repositories
{
    public class JwtTokenRepository : IJwtTokenRepository
    {
        public JwtTokenRepository()
        { 
        }

        public string CreateJwtToken(string secret, string name, string login)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            byte[] key = System.Text.Encoding.ASCII.GetBytes(secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new System.Security.Claims.Claim[] { new System.Security.Claims.Claim(name, login) }),
                Expires = DateTime.UtcNow.AddDays(3),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var resetToken = tokenHandler.WriteToken(token);

            return resetToken;
        }
    }
}
