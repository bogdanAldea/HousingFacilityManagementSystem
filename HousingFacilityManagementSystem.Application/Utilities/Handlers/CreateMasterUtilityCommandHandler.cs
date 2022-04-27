using HousingFacilityManagementSystem.Application.Utilities.Commands;
using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Utilities.Handlers
{
    internal class CreateMasterUtilityCommandHandler : IRequestHandler<CreateMasterUtilityCommand, MasterConsumableUtility>
    {

        private readonly IRepository<MasterConsumableUtility> _repository;

        public CreateMasterUtilityCommandHandler(IRepository<MasterConsumableUtility> repository)
        {
            _repository = repository;
        }

        public async Task<MasterConsumableUtility> Handle(CreateMasterUtilityCommand request, CancellationToken cancellationToken)
        {
            MasterConsumableUtility utility = new MasterConsumableUtility(name: request.Name);
            utility.IndexMeter = request.TotalIndex;
            utility.BuildingId = request.BuildingId;

            _repository.Add(utility);
            return await Task.FromResult(utility);
        }
    }
}
