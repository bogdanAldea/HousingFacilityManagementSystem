using HousingFacilityManagementSystem.Application.Apartments.Commands;
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
    public class UpdateResidentsCommandHandler : IRequestHandler<UpdateResidentsCommand, Apartment>
    {

        private readonly IRepository<Apartment> _repository;

        public UpdateResidentsCommandHandler(IRepository<Apartment> repository)
        {
            _repository = repository;
        }

        public Task<Apartment> Handle(UpdateResidentsCommand request, CancellationToken cancellationToken)
        {
            Apartment apartment = _repository.GetById(request.Id);
            apartment.Residents = request.Residents;
            _repository.Update(apartment);

            return Task.FromResult(apartment);
        }
    }
}
