using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Services
{
    public interface IUtilitiesService
    {
        public Task<MasterConsumableUtility> GetMasterUtility(int id);
        public Task<BranchedConsumableUtility> GetBranchedUtility(int id);
        public Task PutBranchedutility(BranchedConsumableUtility branchedUtility);
    }
}
