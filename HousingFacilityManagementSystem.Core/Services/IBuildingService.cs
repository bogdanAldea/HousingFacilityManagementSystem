using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Services
{
    public interface IBuildingService
    {
        public Task<Building> CreateBuilding(int id, int administratorId, List<MasterConsumableUtility> utilities);
    }
}
