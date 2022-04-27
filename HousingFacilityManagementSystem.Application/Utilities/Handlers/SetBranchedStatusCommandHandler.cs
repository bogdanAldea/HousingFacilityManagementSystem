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
    public class SetBranchedStatusCommandHandler : IRequestHandler<SetBranchedStatusCommand, BranchedConsumableUtility>
    {

        private readonly IRepository<BranchedConsumableUtility> _repository;

        public SetBranchedStatusCommandHandler(IRepository<BranchedConsumableUtility> repository)
        {
            _repository = repository;
        }

        public async Task<BranchedConsumableUtility> Handle(SetBranchedStatusCommand request, CancellationToken cancellationToken)
        {
            BranchedConsumableUtility utility = _repository.GetById(request.Id);
            utility.IsBranched = request.IsBranched;

            _repository.Update(utility);
            return await Task.FromResult(utility);
        }
    }
}
