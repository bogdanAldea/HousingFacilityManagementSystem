using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Repositories.Interfaces
{
    public interface IMasterUtilityRepository
    {
        public Task<MasterConsumableUtility> Get(int id);
        public Task<MasterConsumableUtility> GetByName(string name);
        public Task<ICollection<MasterConsumableUtility>> GetAllByBuilding(int buildingId);
        public Task Put(MasterConsumableUtility utility);
    }
}
