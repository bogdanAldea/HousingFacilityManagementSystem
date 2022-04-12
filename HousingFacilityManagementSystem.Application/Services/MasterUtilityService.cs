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
    public class MasterUtilityService : IMasterutilityService
    {

        private readonly IGenericRepository<MasterConsumableUtility> _masterUtilityRepository;

        public MasterUtilityService(IGenericRepository<MasterConsumableUtility> masterUtilityRepository)
        {
            _masterUtilityRepository = masterUtilityRepository;
        }

        public void CreateMasterUtility(string name)
        {
            MasterConsumableUtility utility = new MasterConsumableUtility(name);
            _masterUtilityRepository.Add(utility);
        }

        public void SetIndexForCurrentMonth(int masterUtilityId, int currentMonthIndex)
        {
            MasterConsumableUtility utility = _masterUtilityRepository.GetById(masterUtilityId);
            utility.CurrentMonthIndex = currentMonthIndex;
            _masterUtilityRepository.Update(utility);
        }

        public void SetPrice(int masterUtilityId, decimal price)
        {
            MasterConsumableUtility utility = _masterUtilityRepository.GetById(masterUtilityId);
            utility.Price = price;
            _masterUtilityRepository.Update(utility);
        }

        public void SetTotalIndexMeter(int masterUtilityId, int totalIndexMeter)
        {
            MasterConsumableUtility utility = _masterUtilityRepository.GetById(masterUtilityId);
            utility.IndexMeter = totalIndexMeter;
            _masterUtilityRepository.Update(utility);
        }
    }
}
