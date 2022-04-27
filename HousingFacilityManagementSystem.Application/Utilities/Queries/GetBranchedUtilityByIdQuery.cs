using HousingFacilityManagementSystem.Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Utilities.Queries
{
    public class GetBranchedUtilityByIdQuery : IRequest<BranchedConsumableUtility>
    {
        public int Id { get; set; }
    }
}
