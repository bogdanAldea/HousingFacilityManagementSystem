using HousingFacilityManagementSystem.Application.Identity.Commands;
using HousingFacilityManagementSystem.Application.Options;
using HousingFacilityManagementSystem.Core.Models.Users;
using HousingFacilityManagementSystem.Core.Repositories.Interfaces;
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
    public class LoginAdminHandler : IRequestHandler<LoginAdminCommand, OperationResult<string>>
    {

        private readonly IIdentityRepository<AdministratorProfile> _repository;
        private readonly UserManager<IdentityUser> _userManager;

        public LoginAdminHandler(IIdentityRepository<AdministratorProfile> repository, UserManager<IdentityUser> userManager)
        {
            _repository = repository;
            _userManager = userManager;
        }

        public async Task<OperationResult<string>> Handle(LoginAdminCommand request, CancellationToken cancellationToken)
        {
            OperationResult<string> result = new OperationResult<string>();

            var existingIdentity = await _userManager.FindByEmailAsync(request.Email);
            if (existingIdentity == null)
            {
                result.IsError = true;
                result.ErrorCode = 404;
                result.Errors.Add($"User with email of {request.Email} does not exist.");
                return result;

            }

            var passwordIsValid = await _userManager.CheckPasswordAsync(existingIdentity, request.Password);
            if (!passwordIsValid)
            {
                result.IsError = true;
                result.ErrorCode = 400;
                result.Errors.Add("Password Is invalid.");
                return result;
            }

            var adminProfile = await _repository.GetByIdentityId(existingIdentity.Id);

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

            var tokenCreate = tokenHandler.CreateToken(tokenDescriptor);
            var token = tokenHandler.WriteToken(tokenCreate);
            result.Payload = token;
            return result;
        }
    }
}
