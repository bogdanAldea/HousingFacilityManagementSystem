using HousingFacilityManagementSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Factories
{
    public class BranchedConsumableUtilityFactory : IConsumableUtilityFactory<BranchedConsumableUtility>
    {
        public BranchedConsumableUtility CreateConsumableUtility(int indexMeter, Utility utility)
        {
            return new BranchedConsumableUtility(indexMeter: indexMeter, utility: utility);
        }
    }
}
