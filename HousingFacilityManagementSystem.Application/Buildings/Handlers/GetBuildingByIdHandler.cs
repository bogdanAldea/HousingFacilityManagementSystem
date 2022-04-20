using HousingFacilityManagementSystem.Application.Buildings.Queries;
using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Buildings.Handlers
{
    public class GetBuildingByIdHandler : IRequestHandler<GetBuildingByIdQuery, Building>
    {

        private readonly IRepository<Building> _repository;

        public GetBuildingByIdHandler(IRepository<Building> repository)
        {
            _repository = repository;
        }

        public async Task<Building> Handle(GetBuildingByIdQuery request, CancellationToken cancellationToken)
        {
            var building = _repository.GetById(id: request.Id);
            return building;
        }
    }
}
