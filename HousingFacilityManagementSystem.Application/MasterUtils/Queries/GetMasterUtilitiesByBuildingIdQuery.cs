using HousingFacilityManagementSystem.Application.Options;
using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Models.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.MasterUtils.Queries
{
    public class GetMasterUtilitiesByBuildingIdQuery : IRequest<OperationResult<List<MasterConsumableUtility>>>
    {
        public int BuildingId { get; set; }
    }
}
