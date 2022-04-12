using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Services
{
    internal interface IBranchedUtilityService
    {
        public void CreateNewBranchedUtility(string name);
        public void SetTotalIndexMeter(int brachedUtilityId, int index);
        public void SetCurrentIndexForCurrentMonth(int branchedUtilityId, int currentMonthIndex);
        public void SetBranchedStatus(int branchedUtilityId, bool isBranched);
        public void SetAmountToPay(int branchedUtilityId, decimal amountToPay);
    }
}
