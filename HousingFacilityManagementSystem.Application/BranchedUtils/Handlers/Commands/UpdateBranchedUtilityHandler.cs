using HousingFacilityManagementSystem.Application.BranchedUtils.Commands;
using HousingFacilityManagementSystem.Application.Options;
using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Models.Utilities;
using HousingFacilityManagementSystem.Core.Repositories.Interfaces;
using HousingFacilityManagementSystem.Core.Services;
using MediatR;

namespace HousingFacilityManagementSystem.Application.BranchedUtils.Handlers.Commands
{
    public class UpdateBranchedUtilityHandler : IRequestHandler<UpdateBranchedUtilityCommand, OperationResult<BranchedConsumableUtility>>
    {

        private readonly IUtilitiesService _service;

        public UpdateBranchedUtilityHandler(IUtilitiesService service)
        {
            _service = service;
        }

        public async Task<OperationResult<BranchedConsumableUtility>> Handle(UpdateBranchedUtilityCommand request, CancellationToken cancellationToken)
        {
            OperationResult<BranchedConsumableUtility> result = new OperationResult<BranchedConsumableUtility>();

            BranchedConsumableUtility branchedUtility = await _service.GetBranchedUtility(request.Id);
            MasterConsumableUtility masterUtility = await _service.GetMasterUtility(request.MasterConsumableUtilityId);

            if (branchedUtility == null || masterUtility == null)
            {
                result.IsError = true;
                result.ErrorCode = 404;
                result.Errors.Add("Either the branched utility or the master utility could not be found.");
                return result;
            }

            branchedUtility.CurrentMonthIndex = request.CurrentMonthIndex;
            branchedUtility.IndexMeter += request.CurrentMonthIndex;
            branchedUtility.IsBranched = request.IsBranched;
            branchedUtility.CalculatePayment(masterUtility.Price);

            await _service.PutBranchedutility(branchedUtility);


            result.Payload = branchedUtility;
            return result;
        }

        //public async Task<OperationResult<BranchedConsumableUtility>> Handle(UpdateBranchedUtilityCommand request, CancellationToken cancellationToken)
        //{
        //    OperationResult<BranchedConsumableUtility> result = new OperationResult<BranchedConsumableUtility>();

        //    BranchedConsumableUtility utility = await _repository.Get(request.Id);
        //    if (utility == null)
        //    {
        //        result.IsError = true;
        //        result.Errors.Add($"Branched utility with the id of {request.Id} was not found.");
        //        result.ErrorCode = 404;
        //        return result;
        //    }

        //    utility.CurrentMonthIndex = request.CurrentMonthIndex;
        //    utility.IndexMeter += request.CurrentMonthIndex;
        //    utility.IsBranched = request.IsBranched;

        //    await _repository.Put(utility);
        //    result.Payload = utility;
        //    return result;
        //}
    }
}
