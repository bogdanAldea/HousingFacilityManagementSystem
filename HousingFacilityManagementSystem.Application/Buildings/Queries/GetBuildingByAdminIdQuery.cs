using HousingFacilityManagementSystem.Application.Options;
using HousingFacilityManagementSystem.Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Buildings.Queries
{
    public class GetBuildingByAdminIdQuery : IRequest<OperationResult<Building>>
    {
        public int AdministratorId { get; set; }
    }
}
