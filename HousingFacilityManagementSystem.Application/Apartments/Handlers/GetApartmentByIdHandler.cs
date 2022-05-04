using HousingFacilityManagementSystem.Application.Apartments.Queries;
using HousingFacilityManagementSystem.Core.Exceptions;
using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Apartments.Handlers
{
    public class GetApartmentByIdHandler : IRequestHandler<GetApartmentByIdQuery, Apartment>
    {

        private readonly IRepository<Apartment> _repository;

        public GetApartmentByIdHandler(IRepository<Apartment> repository)
        {
            _repository = repository;
        }

        public async Task<Apartment> Handle(GetApartmentByIdQuery request, CancellationToken cancellationToken)
        { 
            try
            {
                Apartment apartment = _repository.GetById(request.Id);
                return await Task.FromResult(apartment);
            }
            catch (EntityIdNotFoundException)
            {
                throw;
            }
        }
    }
}
