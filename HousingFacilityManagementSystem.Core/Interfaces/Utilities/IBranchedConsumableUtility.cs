using HousingFacilityManagementSystem.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Interfaces.Utilities
{
    public interface IBranchedConsumableUtility : IConsumableUtility, IBranchable
    {
        public decimal AmountToPay { get; set; }
    }
}
