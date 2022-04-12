using HousingFacilityManagementSystem.Core.Models.Utilities;
using HousingFacilityManagementSystem.Core.Repositories;
using HousingFacilityManagementSystem.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Services
{
    public class BranchedUtilityService : IBranchedUtilityService
    {

        private readonly IGenericRepository<BranchedConsumableUtility> _branchedUtilityRepository;

        public BranchedUtilityService(IGenericRepository<BranchedConsumableUtility> branchedUtilityRepository)
        {
            _branchedUtilityRepository = branchedUtilityRepository;
        }

        public void CreateNewBranchedUtility(string name)
        {
            BranchedConsumableUtility utility = new BranchedConsumableUtility(name: name);
            _branchedUtilityRepository.Add(utility);
        }

        public void SetBranchedStatus(int branchedUtilityId, bool isBranched)
        {
            BranchedConsumableUtility utility = _branchedUtilityRepository.GetById(branchedUtilityId);
            utility.IsBranched = isBranched;
            _branchedUtilityRepository.Update(utility);
        }

        public void SetCurrentIndexForCurrentMonth(int branchedUtilityId, int currentMonthIndex)
        {
            BranchedConsumableUtility utility = _branchedUtilityRepository.GetById(branchedUtilityId);
            utility.CurrentMonthIndex = currentMonthIndex;
            _branchedUtilityRepository.Update(utility);
        }

        public void SetTotalIndexMeter(int branchedUtilityId, int totalIndex)
        {
            BranchedConsumableUtility utility = _branchedUtilityRepository.GetById(branchedUtilityId);
            utility.IndexMeter = totalIndex;
        }
    }
}
