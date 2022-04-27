using HousingFacilityManagementSystem.Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Utilities.Commands
{
    public class CreateBranchedUtilityCommand : IRequest<BranchedConsumableUtility>
    {
        public int ApartmentId { get; set; }
        public string Name { get; set; }
    }
}
