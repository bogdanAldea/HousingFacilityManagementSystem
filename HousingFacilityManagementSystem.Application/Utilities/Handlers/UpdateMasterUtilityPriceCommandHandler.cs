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
    public class UpdateMasterUtilityPriceCommandHandler : IRequestHandler<UpdateMasterUtilityPriceCommand, MasterConsumableUtility>
    {

        private readonly IRepository<MasterConsumableUtility> _repository;

        public UpdateMasterUtilityPriceCommandHandler(IRepository<MasterConsumableUtility> repository)
        {
            _repository = repository;
        }

        public async Task<MasterConsumableUtility> Handle(UpdateMasterUtilityPriceCommand request, CancellationToken cancellationToken)
        {
            MasterConsumableUtility utility = _repository.GetById(request.Id);
            utility.Price = request.Price;
            _repository.Update(utility);
            return await Task.FromResult(utility);
        }
    }
}
