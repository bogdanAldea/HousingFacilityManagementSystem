using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Services
{
    public interface IUniversalUtilityService
    {
        public void CreateNewUniversalUtility(string name, decimal price);
        public void SetPrice(int universalUtilityId, decimal price);
    }
}
