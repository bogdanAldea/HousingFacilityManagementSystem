using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Services
{
    public class JwtTokenService
    {
        private readonly byte[] _signingKey;

        public JwtTokenService()
        {
            _signingKey = Encoding.ASCII.GetBytes("jfr2txodg2ccc91o45nbwl9bwau8m2mv");
        }

        public JwtSecurityTokenHandler TokenHandler = new JwtSecurityTokenHandler();

        public SecurityToken CreateSecurityToken(ClaimsIdentity identity)
        {
            var tokenDescriptor = GetTokenDescriptor(identity);

            return TokenHandler.CreateToken(tokenDescriptor);
        }

        public string WriteToken(SecurityToken token)
        {
            return TokenHandler.WriteToken(token);
        }

        private SecurityTokenDescriptor GetTokenDescriptor(ClaimsIdentity identity)
        {
            return new SecurityTokenDescriptor()
            {
                Subject = identity,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(_signingKey), SecurityAlgorithms.HmacSha256Signature)
            };
        }
    }
}
