using HousingFacilityManagementSystem.Application.MasterUtils.Queries;
using HousingFacilityManagementSystem.Application.Options;
using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Models.Utilities;
using HousingFacilityManagementSystem.Core.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.MasterUtils.Handlers.Queries
{
    internal class GetMasterUtilByIdHandler : IRequestHandler<GetMasterUtilityByIdQuery, OperationResult<MasterConsumableUtility>>
    {

        private readonly IMasterUtilityRepository _repository;

        public GetMasterUtilByIdHandler(IMasterUtilityRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<MasterConsumableUtility>> Handle(GetMasterUtilityByIdQuery request, CancellationToken cancellationToken)
        {
            OperationResult<MasterConsumableUtility> result = new OperationResult<MasterConsumableUtility>();

            MasterConsumableUtility utility = await _repository.Get(request.Id);
            if (utility == null)
            {
                result.IsError = true;
                result.ErrorCode = 404;
                result.Errors.Add($"Master Utility with the id of {request.Id} was not found.");
                return result;
            }
            result.Payload = utility;
            return result;
        }
    }
}
