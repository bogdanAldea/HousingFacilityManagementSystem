using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HousingFacilityManagementSystem.Application.Buildings.Commands;
using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Repositories;
using MediatR;

namespace HousingFacilityManagementSystem.Application.Buildings.Queries
{
    public class CreateBuildingCommandHandler : IRequestHandler<CreateBuildingCommand, Building>
    {

        private readonly IRepository<Building> _repository;

        public CreateBuildingCommandHandler(IRepository<Building> repository)
        {
            _repository = repository;
        }

        public async Task<Building> Handle(CreateBuildingCommand request, CancellationToken cancellationToken)
        {
           var building = new Building(capacity: request.Capacity);
            building.AddApartments();
            _repository.Add(building);
            return await Task.FromResult(building);
        }
    }
}
