using AutoMapper;
using HousingFacilityManagementSystem.Application.Identity.Commands;
using HousingFacilityManagementSystem.Application.Identity.DTOs;
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

namespace HousingFacilityManagementSystem.Application.Identity.Handlers.Commands
{
    public class RegisterAdminHandler : IRequestHandler<RegisterAdminCommand, OperationResult<AdministratorProfile>>
    {

        private readonly IIdentityRepository<AdministratorProfile> _repository;
        private readonly UserManager<IdentityUser> _userManager;

        public RegisterAdminHandler(IIdentityRepository<AdministratorProfile> repository, UserManager<IdentityUser> userManager)
        {
            _repository = repository;
            _userManager = userManager;
        }

        public async Task<OperationResult<AdministratorProfile>> Handle(RegisterAdminCommand request, CancellationToken cancellationToken)
        {
            OperationResult<AdministratorProfile> result = new OperationResult<AdministratorProfile>();
            
            var existingIdentity = await _userManager.FindByEmailAsync(request.Email);
            
            if (existingIdentity != null)
            {
                result.IsError = true;
                result.ErrorCode = 400;
                result.Errors.Add($"A user with the email {request.Email} already exists.");
                return result;
            }

            var database = _repository.Database();

            //await using var transaction = await database.BeginTransactionAsync(cancellationToken);
    

            var newIdentity = new IdentityUser
            {
                Email = request.Email,
                UserName = request.Username,
                PhoneNumber = request.PhoneNumber,
            };

            var createdIdentity = await _userManager.CreateAsync(newIdentity, request.Password);
            if (!createdIdentity.Succeeded)
            {
                //await transaction.RollbackAsync(cancellationToken);
                
                foreach (var error in createdIdentity.Errors)
                {
                    result.Errors.Add(error.Description);
                    result.IsError = true;
                    result.ErrorCode = 400;
                }

                return result;
            }

            var adminProfile = new AdministratorProfile
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                IdentityId = newIdentity.Id,
                Email = request.Email,
                Username = request.Username,
                PhoneNumber= request.PhoneNumber,
            };

            await _repository.AddIdentityProfile(adminProfile);
            result.Payload = adminProfile;
            return result;
        }
    }
}
