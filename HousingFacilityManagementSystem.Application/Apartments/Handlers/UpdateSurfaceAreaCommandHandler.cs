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
    internal class UpdateSurfaceAreaCommandHandler : IRequestHandler<UpdateSurfaceAreaCommand, Apartment>
    {

        private readonly IRepository<Apartment> _repository;

        public UpdateSurfaceAreaCommandHandler(IRepository<Apartment> repository)
        {
            _repository = repository;
        }

        public Task<Apartment> Handle(UpdateSurfaceAreaCommand request, CancellationToken cancellationToken)
        {
            Apartment apartment = _repository.GetById(request.Id);       
            apartment.SurfaceArea = request.SurfaceArea;
            _repository.Update(apartment);
            return Task.FromResult(apartment);
        }
    }
}
