using HousingFacilityManagementSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Factories
{
    internal class MasterConsumableUtilityFactory : IConsumableUtilityFactory<MasterConsumableUtility>
    {
        public MasterConsumableUtility CreateConsumableUtility(string name, int totalIndexMeter, Utility utility)
        {
            return new MasterConsumableUtility()
        }
    }
}
