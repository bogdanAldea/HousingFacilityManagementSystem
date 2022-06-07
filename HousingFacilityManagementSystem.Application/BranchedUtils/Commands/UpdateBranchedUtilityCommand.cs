using HousingFacilityManagementSystem.Application.Options;
using HousingFacilityManagementSystem.Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.BranchedUtils.Commands
{
    public class UpdateBranchedUtilityCommand : IRequest<OperationResult<BranchedConsumableUtility>>
    {
        public int Id { get; set; }
        public int CurrentMonthIndex { get; set; }
        public bool IsBranched { get; set; }
        public int MasterConsumableUtilityId { get; set; }
    }
}
