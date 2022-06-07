using HousingFacilityManagementSystem.Application.Options;
using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Models.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Buildings.Commands
{
    public class CreateBuildingCommand : IRequest<OperationResult<Building>>
    {
        public int Capacity { get; set; }
        public int AdministratorId { get; set; }
        public List<MasterConsumableUtility> MasterConsumableUtilities { get; set; }
    }
}
