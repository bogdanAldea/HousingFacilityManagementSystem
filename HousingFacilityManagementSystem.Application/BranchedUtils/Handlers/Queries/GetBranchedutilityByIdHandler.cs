using HousingFacilityManagementSystem.Application.BranchedUtils.Queries;
using HousingFacilityManagementSystem.Application.Options;
using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.BranchedUtils.Handlers.Queries
{
    public class GetBranchedutilityByIdHandler : IRequestHandler<GetBranchedUtilityById, OperationResult<BranchedConsumableUtility>>
    {

        private readonly IBranchedUtilityRepository _repository;

        public GetBranchedutilityByIdHandler(IBranchedUtilityRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<BranchedConsumableUtility>> Handle(GetBranchedUtilityById request, CancellationToken cancellationToken)
        {
            OperationResult<BranchedConsumableUtility> result = new OperationResult<BranchedConsumableUtility>();
            BranchedConsumableUtility branchedUtility = await _repository.Get(request.Id);

            if (branchedUtility == null)
            {
                result.IsError = true;
                result.ErrorCode = 404;
                result.Errors.Add("Utility could not be found.");
                return result;
            }

            result.Payload = branchedUtility;
            return result;
        }
    }
}
