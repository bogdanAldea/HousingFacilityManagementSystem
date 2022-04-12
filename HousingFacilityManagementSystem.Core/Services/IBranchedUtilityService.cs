using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Services
{
    public interface IBranchedUtilityService
    {
        public void CreateNewBranchedUtility(string name);
        public void SetTotalIndexMeter(int branchedUtilityId, int totalIndex);
        public void SetCurrentIndexForCurrentMonth(int branchedUtilityId, int currentMonthIndex);
        public void SetBranchedStatus(int branchedUtilityId, bool isBranched);
    }
}
