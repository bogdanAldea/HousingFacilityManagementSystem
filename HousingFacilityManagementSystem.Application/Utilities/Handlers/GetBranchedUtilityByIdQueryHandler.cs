using HousingFacilityManagementSystem.Application.Utilities.Queries;
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
    public class GetBranchedUtilityByIdQueryHandler : IRequestHandler<GetBranchedUtilityByIdQuery, BranchedConsumableUtility>
    {

        private readonly IRepository<BranchedConsumableUtility> _repository;

        public GetBranchedUtilityByIdQueryHandler(IRepository<BranchedConsumableUtility> repository)
        {
            _repository = repository;
        }

        public async Task<BranchedConsumableUtility> Handle(GetBranchedUtilityByIdQuery request, CancellationToken cancellationToken)
        {
            BranchedConsumableUtility utility = _repository.GetById(request.Id);
            return await Task.FromResult(utility);
        }
    }
}
