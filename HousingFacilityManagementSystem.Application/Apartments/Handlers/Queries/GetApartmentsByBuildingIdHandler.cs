using HousingFacilityManagementSystem.Application.Apartments.Queries;
using HousingFacilityManagementSystem.Application.Options;
using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Apartments.Handlers.Queries
{
    public class GetApartmentsByBuildingIdHandler : IRequestHandler<GetApartmentsByBuildingIdQuery, OperationResult<List<Apartment>>>
    {

        private readonly IApartmentRepository _repository;

        public GetApartmentsByBuildingIdHandler(IApartmentRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<Apartment>>> Handle(GetApartmentsByBuildingIdQuery request, CancellationToken cancellationToken)
        {
            OperationResult<List<Apartment>> result = new OperationResult<List<Apartment>>();
            ICollection<Apartment> apartments = await _repository.GetAllByBuilding(request.Id);

            if ( apartments == null )
            {
                result.IsError = true;
                result.Errors.Add($"Queryset of type {typeof(Apartment)} was not found.");
                return result;
            }

            result.Payload = apartments.ToList();
            return result;
        }
    }
}
