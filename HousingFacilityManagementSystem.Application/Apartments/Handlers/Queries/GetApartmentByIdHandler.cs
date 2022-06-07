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
    public class GetApartmentByIdHandler : IRequestHandler<GetApartmentByIdQuery, OperationResult<Apartment>>
    {

        private readonly IApartmentRepository _repository;

        public GetApartmentByIdHandler(IApartmentRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<Apartment>> Handle(GetApartmentByIdQuery request, CancellationToken cancellationToken)
        {
            OperationResult<Apartment> result = new OperationResult<Apartment>();
            Apartment apartment = await _repository.Get(request.Id);
            if (apartment == null)
            {
                result.IsError = true;
                result.ErrorCode = 404;
                result.Errors.Add($"Entity of type {typeof(Apartment)} with the id {request.Id} was not found.");
                return result;
            }

            result.Payload = apartment;
            return result;
        }
    }
}
