using HousingFacilityManagementSystem.Application.Identity.Commands;
using HousingFacilityManagementSystem.Core.Models.Users;
using HousingFacilityManagementSystem.Infrastructure.Repositories.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Identity.Handlers
{
    public class LoginAdminCommandHandler : IRequestHandler<LoginAdminCommand, string>
    {

        private readonly IIdentityRepository<AdministratorProfile> _repository;
        private readonly UserManager<IdentityUser> _userManager;

        public LoginAdminCommandHandler(IIdentityRepository<AdministratorProfile> repository, UserManager<IdentityUser> userManager)
        {
            _repository = repository;
            _userManager = userManager;
        }

        public async Task<string> Handle(LoginAdminCommand request, CancellationToken cancellationToken)
        {
            var existingIdentity = await _userManager.FindByEmailAsync(request.Email);
            if (existingIdentity == null)
            {
                return await Task.FromResult($"User with email {request.Email} does not exist");
            }


            var passwordIsValid = await _userManager.CheckPasswordAsync(existingIdentity, request.Password);
            if (!passwordIsValid)
            {
                return await Task.FromResult("Password is invalid.");
            }

            var adminProfile = _repository.GetByIdentityId(existingIdentity.Id);

            var tokenHandler = new JwtSecurityTokenHandler();
            var signingKey = Encoding.ASCII.GetBytes("jfr2txodg2ccc91o45nbwl9bwau8m2mv");
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                            new Claim(JwtRegisteredClaimNames.Sub, existingIdentity.Email),
                            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                            new Claim(JwtRegisteredClaimNames.Email, existingIdentity.Email),
                            new Claim("IdentityId", existingIdentity.Id),
                            new Claim("UserProfileId", adminProfile.Id.ToString())
                }),

                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(signingKey), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var result = tokenHandler.WriteToken(token);
            return await Task.FromResult(result);
        }
    }
}
