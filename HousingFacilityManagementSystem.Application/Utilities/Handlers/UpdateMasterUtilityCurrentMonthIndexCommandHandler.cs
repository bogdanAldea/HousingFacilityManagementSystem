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
    public class UpdateMasterUtilityCurrentMonthIndexCommandHandler : IRequestHandler<UpdateMasterUtilityCurrentMonthIndexCommand, MasterConsumableUtility>
    {

        private readonly IRepository<MasterConsumableUtility> _repository;

        public UpdateMasterUtilityCurrentMonthIndexCommandHandler(IRepository<MasterConsumableUtility> repository)
        {
            _repository = repository;
        }

        public async Task<MasterConsumableUtility> Handle(UpdateMasterUtilityCurrentMonthIndexCommand request, CancellationToken cancellationToken)
        {
            MasterConsumableUtility utility = _repository.GetById(request.Id);
            utility.CurrentMonthIndex = request.CurrentMonthIndex;
            utility.IndexMeter += request.CurrentMonthIndex;
            _repository.Update(utility);
            return await Task.FromResult(utility);
        }
    }
}
