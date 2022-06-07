using HousingFacilityManagementSystem.Application.Buildings.Handlers.Queries;
using HousingFacilityManagementSystem.Application.MasterUtils.Queries;
using HousingFacilityManagementSystem.Application.Options;
using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Models.Utilities;
using HousingFacilityManagementSystem.Core.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.MasterUtils.Handlers.Queries
{
    public class GetMasterUtilitiesByBuildingIdHandler : IRequestHandler<GetMasterUtilitiesByBuildingIdQuery, OperationResult<List<MasterConsumableUtility>>>
    {

        private readonly IMasterUtilityRepository _repository;

        public GetMasterUtilitiesByBuildingIdHandler(IMasterUtilityRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<MasterConsumableUtility>>> Handle(GetMasterUtilitiesByBuildingIdQuery request, CancellationToken cancellationToken)
        {
            OperationResult<List<MasterConsumableUtility>> result = new OperationResult<List<MasterConsumableUtility>>();
            ICollection<MasterConsumableUtility> utilities = await _repository.GetAllByBuilding(request.BuildingId);

            result.Payload = utilities.ToList();
            return result;
        }
    }
}
