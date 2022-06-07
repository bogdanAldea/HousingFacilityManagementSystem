using HousingFacilityManagementSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Repositories.Interfaces
{
    public interface IBranchedUtilityRepository
    {
        public Task<BranchedConsumableUtility> Get(int id);
        public Task<IEnumerable<BranchedConsumableUtility>> GetAllByBuilding(int buildingId);
        public Task Put(BranchedConsumableUtility utility);
    }
}
