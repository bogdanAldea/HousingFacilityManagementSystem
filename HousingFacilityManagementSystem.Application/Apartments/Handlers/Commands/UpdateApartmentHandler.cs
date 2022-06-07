using HousingFacilityManagementSystem.Application.Apartments.Commands;
using HousingFacilityManagementSystem.Application.Options;
using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Apartments.Handlers.Commands
{
    public class UpdateApartmentHandler : IRequestHandler<UpdateApartmentCommand, OperationResult<Apartment>>
    {

        private readonly IApartmentRepository _repository;

        public UpdateApartmentHandler(IApartmentRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<Apartment>> Handle(UpdateApartmentCommand request, CancellationToken cancellationToken)
        {
            OperationResult<Apartment> result = new OperationResult<Apartment>();

            Apartment apartment = await _repository.Get(request.Id);
            if (apartment == null)
            {
                result.ErrorCode = 404;
                result.Errors.Add($"Entity of type {typeof(Apartment)} with id of {request.Id} was not found.");
                return result;
            }

            apartment.Residents = request.Residents;
            apartment.SurfaceArea = request.SurfaceArea;

            await _repository.Put(apartment);
            result.Payload = apartment;
            return result;
        }
    }
}
