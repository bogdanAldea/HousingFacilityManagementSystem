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
    public class CreateBranchedUtilityCommandHandler : IRequestHandler<CreateBranchedUtilityCommand, BranchedConsumableUtility>
    {

        private readonly IRepository<BranchedConsumableUtility> _repository;

        public CreateBranchedUtilityCommandHandler(IRepository<BranchedConsumableUtility> repository)
        {
            _repository = repository;
        }

        public async Task<BranchedConsumableUtility> Handle(CreateBranchedUtilityCommand request, CancellationToken cancellationToken)
        {
            BranchedConsumableUtility utility = new BranchedConsumableUtility(request.Name) { ApartmentId=request.ApartmentId };
            _repository.Add(utility);
            return await Task.FromResult(utility);
        }
    }
}
