using HousingFacilityManagementSystem.Application.Options;
using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Models.Utilities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.MasterUtils.Commands
{
    public class UpdateMasterUtilityCommand : IRequest<OperationResult<MasterConsumableUtility>>
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int CurrentMonthIndex { get; set; }
    }
}
