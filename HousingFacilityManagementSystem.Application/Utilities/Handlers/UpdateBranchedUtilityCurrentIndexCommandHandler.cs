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
    public class UpdateBranchedUtilityCurrentIndexCommandHandler : IRequestHandler<UpdateBranchedUtilityCurrentIndexCommand, BranchedConsumableUtility>
    {

        private readonly IRepository<BranchedConsumableUtility> _repository;

        public UpdateBranchedUtilityCurrentIndexCommandHandler(IRepository<BranchedConsumableUtility> repository)
        {
            _repository = repository;   
        }

        public async Task<BranchedConsumableUtility> Handle(UpdateBranchedUtilityCurrentIndexCommand request, CancellationToken cancellationToken)
        {
            BranchedConsumableUtility utility = _repository.GetById(request.Id);
            utility.CurrentMonthIndex = request.CurrentMonthIndex;
            utility.IndexMeter += request.CurrentMonthIndex;

            _repository.Update(utility);
            return await Task.FromResult(utility);
        }
    }
}
