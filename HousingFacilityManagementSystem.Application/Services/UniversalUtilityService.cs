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
    public class UniversalUtilityService : IUniversalUtilityService
    {

        private readonly IGenericRepository<UniversalUtility> _universalUtilityRepository;

        public UniversalUtilityService(IGenericRepository<UniversalUtility> universalUtilityRepository)
        {
            _universalUtilityRepository = universalUtilityRepository;
        }

        public void CreateNewUniversalUtility(string name, decimal price)
        {
            UniversalUtility utility = new UniversalUtility(name: name, price: price);
            _universalUtilityRepository.Add(utility);
        }

        public void SetPrice(int universalUtilityId, decimal price)
        {
            UniversalUtility utility = _universalUtilityRepository.GetById(universalUtilityId);
            utility.Price = price;
            _universalUtilityRepository.Update(utility);
        }
    }
}
