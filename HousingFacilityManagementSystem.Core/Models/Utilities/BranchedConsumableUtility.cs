using HousingFacilityManagementSystem.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Models
{
    public class BranchedConsumableUtility : IBranchedConsumableUtility
    {
        public BranchedConsumableUtility(int indexMeter, Utility utility)
        {
            IndexMeter = indexMeter;
            Utility = utility;
        }

        public int Id { get; set; }
        public Utility Utility { get; set; }
        public int IndexMeter { get; set; }
        public int CurrentMonthIndex { get; set; }
        public bool IsBranched { get; set; } = false;
        public bool AmountToPay { get; set; }
    }
}
