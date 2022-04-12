using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Services
{
    public interface IMasterutilityService
    {
        public void CreateMasterUtility(string name);
        public void SetPrice(decimal price);
        public void SetTotalIndexMeter(int masterUtilityId, int totalIndexMeter);
        public void SetIndexForCurrentMonth(int masterUtilityId, int currentMonthIndex);
    }
}
