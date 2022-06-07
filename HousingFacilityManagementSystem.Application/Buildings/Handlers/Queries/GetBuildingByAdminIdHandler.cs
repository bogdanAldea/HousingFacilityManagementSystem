using HousingFacilityManagementSystem.Application.Buildings.Queries;
using HousingFacilityManagementSystem.Application.Options;
using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Repositories.Interfaces;
using MediatR;


namespace HousingFacilityManagementSystem.Application.Buildings.Handlers.Queries
{
    public class GetBuildingByAdminIdHandler : IRequestHandler<GetBuildingByAdminIdQuery, OperationResult<Building>>
    {

        private readonly IBuildingRepository _repository;

        public GetBuildingByAdminIdHandler(IBuildingRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<Building>> Handle(GetBuildingByAdminIdQuery request, CancellationToken cancellationToken)
        {
            OperationResult<Building> result = new OperationResult<Building>();
            Building building = await _repository.GetByAdminId(request.AdministratorId);
            if (building == null)
            {
                result.IsError = true;
                result.ErrorCode = 404;
                result.Errors.Add("No Building was found for the provided admin.");
                return result;
            }

            result.Payload = building;
            return result;
        }
    }
}
