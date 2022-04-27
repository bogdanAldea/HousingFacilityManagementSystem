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
    public class GetMasterUtilityByIdQueryHandler : IRequestHandler<GetMasterUtilityByIdQuery, MasterConsumableUtility>
    {

        private readonly IRepository<MasterConsumableUtility> _repository;

        public GetMasterUtilityByIdQueryHandler(IRepository<MasterConsumableUtility> repository)
        {
            _repository = repository;
        }

        public async Task<MasterConsumableUtility> Handle(GetMasterUtilityByIdQuery request, CancellationToken cancellationToken)
        {
            MasterConsumableUtility utility = _repository.GetById(request.Id);
            return await Task.FromResult(utility);
        }
    }
}
