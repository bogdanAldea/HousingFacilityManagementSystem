using HousingFacilityManagementSystem.Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Utilities.Commands
{
    public class UpdateBranchedUtilityCurrentIndexCommand : IRequest<BranchedConsumableUtility>
    {
        public int Id { get; set; }
        public int CurrentMonthIndex { get; set; }
    }
}
