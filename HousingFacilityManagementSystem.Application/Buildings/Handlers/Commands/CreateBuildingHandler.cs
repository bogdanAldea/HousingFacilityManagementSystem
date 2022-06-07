using HousingFacilityManagementSystem.Application.Buildings.Commands;
using HousingFacilityManagementSystem.Application.Options;
using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Repositories.Interfaces;
using HousingFacilityManagementSystem.Core.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Buildings.Handlers.Commands
{
    public class CreateBuildingHandler : IRequestHandler<CreateBuildingCommand, OperationResult<Building>>
    {

        private readonly IBuildingService _service;

        public CreateBuildingHandler(IBuildingService service)
        {
            _service = service;
        }

        public async Task<OperationResult<Building>> Handle(CreateBuildingCommand request, CancellationToken cancellationToken)
        {
            OperationResult<Building> result = new OperationResult<Building>();

            var building = await _service.CreateBuilding(request.Capacity, request.AdministratorId, request.MasterConsumableUtilities);
            result.Payload = building;

            return result;
        }
    }
}
