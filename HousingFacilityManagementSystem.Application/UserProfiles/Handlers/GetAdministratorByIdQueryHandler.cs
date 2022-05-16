using HousingFacilityManagementSystem.Application.UserProfiles.Queries;
using HousingFacilityManagementSystem.Core.Models.Users;
using HousingFacilityManagementSystem.Infrastructure.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.UserProfiles.Handlers
{
    public class GetAdministratorByIdQueryHandler : IRequestHandler<GetAdministratorByIdQuery, AdministratorProfile>
    {

        private readonly IIdentityRepository<AdministratorProfile> _repository;

        public GetAdministratorByIdQueryHandler(IIdentityRepository<AdministratorProfile> repository)
        {
            _repository = repository;
        }

        public async Task<AdministratorProfile> Handle(GetAdministratorByIdQuery request, CancellationToken cancellationToken)
        {
            AdministratorProfile adminProfile = _repository.GetById(request.Id);
            return await Task.FromResult(adminProfile);
        }
    }
}
