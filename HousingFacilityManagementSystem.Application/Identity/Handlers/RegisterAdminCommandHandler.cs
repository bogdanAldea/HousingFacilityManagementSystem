using HousingFacilityManagementSystem.Application.Identity.Commands;
using HousingFacilityManagementSystem.Core.Models.Users;
using HousingFacilityManagementSystem.Infrastructure.Repositories.Interfaces;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace HousingFacilityManagementSystem.Application.Identity.Handlers
{
    public class RegisterAdminCommandHandler : IRequestHandler<RegisterAdminCommand, string>
    {

        private readonly IIdentityRepository<AdministratorProfile> _repository;
        private readonly UserManager<IdentityUser> _userManager;

        public RegisterAdminCommandHandler(IIdentityRepository<AdministratorProfile> repository, UserManager<IdentityUser> userManager)
        {
            _repository = repository;
            _userManager = userManager;
        }

        public async Task<string> Handle(RegisterAdminCommand request, CancellationToken cancellationToken)
        {
            var existingIdentity = await _userManager.FindByEmailAsync(request.Email);
            string message;
            if (existingIdentity == null) 
            {

                Console.WriteLine("existing user is null. Can create.");

                var newIdentity = new IdentityUser { Email = request.Email, PhoneNumber = request.Phone, UserName = request.Username };
                var createdIdentity = await _userManager.CreateAsync(newIdentity, request.Password);

                if (createdIdentity.Succeeded)
                {

                    var adminProfile = new AdministratorProfile
                    {
                        FirstName = request.FirstName,
                        LastName = request.LastName,
                        IdentityId = newIdentity.Id
                    };

                    _repository.Add(adminProfile);

                    var tokenHandler = new JwtSecurityTokenHandler();
                    var signingKey = Encoding.ASCII.GetBytes("jfr2txodg2ccc91o45nbwl9bwau8m2mv");
                    var tokenDescriptor = new SecurityTokenDescriptor()
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {
                            new Claim(JwtRegisteredClaimNames.Sub, newIdentity.Email),
                            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                            new Claim(JwtRegisteredClaimNames.Email, newIdentity.Email),
                            new Claim("IdentityId", newIdentity.Id),
                            new Claim("UserProfileId", adminProfile.Id.ToString())
                        }),

                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(signingKey), SecurityAlgorithms.HmacSha256Signature)
                    };

                    var token = tokenHandler.CreateToken(tokenDescriptor);
                    var result = tokenHandler.WriteToken(token);
                    return await Task.FromResult(result);
                }

                else
                {
                    return await Task.FromResult(createdIdentity.ToString());
                }

            } else
            {
                message = "User exists.";
            }

            return await Task.FromResult(message);
        }
    }
}
