using HousingFacilityManagementSystem.Application.MasterUtils.Commands;
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

namespace HousingFacilityManagementSystem.Application.MasterUtils.Handlers.Commands
{
    public class UpdateMasterUtilityHandler : IRequestHandler<UpdateMasterUtilityCommand, OperationResult<MasterConsumableUtility>>
    {

        private readonly IMasterUtilityRepository _repository;

        public UpdateMasterUtilityHandler(IMasterUtilityRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<MasterConsumableUtility>> Handle(UpdateMasterUtilityCommand request, CancellationToken cancellationToken)
        {
            OperationResult<MasterConsumableUtility> result = new OperationResult<MasterConsumableUtility>();
            MasterConsumableUtility utility = await _repository.Get(request.Id);

            if (utility == null)
            {
                result.IsError = true;
                result.ErrorCode = 404;
                result.Errors.Add($"A master utility with the id of {request.Id} was not found.");
            }

            utility.CurrentMonthIndex = request.CurrentMonthIndex;
            utility.IndexMeter += request.CurrentMonthIndex;
            utility.Price = request.Price;

            await _repository.Put(utility);
            result.Payload = utility;
            return result;
        }
    }
}
