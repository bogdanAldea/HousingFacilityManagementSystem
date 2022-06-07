using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Models.Utilities;
using HousingFacilityManagementSystem.Core.Repositories.Interfaces;
using HousingFacilityManagementSystem.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Services
{
    public class UtilitiesService : IUtilitiesService
    {
        private readonly IMasterUtilityRepository _masterUtilRepository;
        private readonly IBranchedUtilityRepository _branchedUtilityRepository;

        public UtilitiesService(IMasterUtilityRepository masterUtilRepository, IBranchedUtilityRepository branchedUtilRepostiory)
        {
            _masterUtilRepository = masterUtilRepository;
            _branchedUtilityRepository = branchedUtilRepostiory;
        }

        public async Task<BranchedConsumableUtility> GetBranchedUtility(int id)
        {
            return await _branchedUtilityRepository.Get(id);
        }

        public async Task<MasterConsumableUtility> GetMasterUtility(int id)
        {
            return await _masterUtilRepository.Get(id);
        }

        public async Task PutBranchedutility(BranchedConsumableUtility branchedUtility)
        {
            await _branchedUtilityRepository.Put(branchedUtility);
        }

    }
}
