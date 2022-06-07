using HousingFacilityManagementSystem.Application.Options;
using HousingFacilityManagementSystem.Application.UserProfiles.Queries;
using HousingFacilityManagementSystem.Core.Models.Users;
using HousingFacilityManagementSystem.Core.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.UserProfiles.Handlers.Queries
{
    internal class GetUserProfileByIdHandler : IRequestHandler<GetUserProfileById, OperationResult<AdministratorProfile>>
    {

        private readonly IIdentityRepository<AdministratorProfile> _repository;

        public GetUserProfileByIdHandler(IIdentityRepository<AdministratorProfile> repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<AdministratorProfile>> Handle(GetUserProfileById request, CancellationToken cancellationToken)
        {
            OperationResult<AdministratorProfile> result = new OperationResult<AdministratorProfile>();

            var profile = await _repository.GetById(request.Id);
            if (profile == null)
            {
                result.IsError = true;
                result.Errors.Add($"User Profile with the id of {request.Id} was not found.");
                return result;
            }
            result.Payload = profile;
            return result;
        }
    }
}
