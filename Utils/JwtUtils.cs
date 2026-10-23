using E_Commerce_Cart_API_UI.Enums;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace E_Commerce_Cart_API_UI.Utils
{
    internal class JwtUtils
    {
        public bool IsTokenValid(string? token)
        {
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            JwtSecurityToken securityToken = handler.ReadJwtToken(token);

            DateTime expTime = securityToken.ValidTo;

            return expTime > DateTime.UtcNow;
        }
    }
}
