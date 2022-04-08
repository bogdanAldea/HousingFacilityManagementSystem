using HousingFacilityManagementSystem.Core.Enums;
using HousingFacilityManagementSystem.Core.Interfaces.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Models.Utilities
{
    public class BranchedConsumableUtility : IBranchedConsumableUtility
    {

        public BranchedConsumableUtility(string name, UtilityType type, int indexMeter)
        {
            Name = name;
            Type = type;
            IndexMeter = indexMeter;
        }

        public decimal AmountToPay { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public UtilityType Type { get; set; }
        public int IndexMeter { get; set; }
        public int CurrentMonthIndex { get; set; }
        public bool IsBranched { get; set; }
    }
}
