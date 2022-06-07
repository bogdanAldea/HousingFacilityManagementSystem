using HousingFacilityManagementSystem.Application.Buildings.Queries;
using HousingFacilityManagementSystem.Application.Options;
using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Buildings.Handlers.Queries
{
    public class GetBuildingByIdHandler : IRequestHandler<GetBuildingByIdQuery, OperationResult<Building>>
    {

        private readonly IBuildingRepository _repository;

        public GetBuildingByIdHandler(IBuildingRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<Building>> Handle(GetBuildingByIdQuery request, CancellationToken cancellationToken)
        {
            OperationResult<Building> result = new OperationResult<Building>();
            Building building = await _repository.GetById(request.Id);

            if (building == null)
            {
                result.IsError = true;
                result.Errors.Add($"Entity of type {typeof(Building)} with id of {request.Id} was not found.");
                return result;
            }

            result.Payload = building;
            return result;
        }
    }
}
