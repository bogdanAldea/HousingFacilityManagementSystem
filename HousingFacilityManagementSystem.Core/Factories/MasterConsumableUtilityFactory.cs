using HousingFacilityManagementSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Factories
{
    public class MasterConsumableUtilityFactory : IConsumableUtilityFactory<MasterConsumableUtility>
    {
        public MasterConsumableUtility CreateConsumableUtility(int indexMeter, Utility utility)
        {
            return new MasterConsumableUtility(indexMeter: indexMeter, utility: utility);
        }
    }
}
