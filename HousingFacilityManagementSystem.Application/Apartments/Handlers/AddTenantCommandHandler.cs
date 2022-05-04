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
    public class AddTenantCommandHandler : IRequestHandler<AddTenantCommand, Apartment>
    {

        private readonly IRepository<Apartment> _repository;

        public AddTenantCommandHandler(IRepository<Apartment> repository)
        {
            _repository = repository;
        }

        public async Task<Apartment> Handle(AddTenantCommand request, CancellationToken cancellationToken)
        {
            Apartment apartment = _repository.GetById(request.Id);
            apartment.TenantId = request.TenantId;
            _repository.Update(apartment);
            return await Task.FromResult(apartment);
        }
    }
}
