using HousingFacilityManagementSystem.Core.Enums;
using HousingFacilityManagementSystem.Core.Interfaces;
using HousingFacilityManagementSystem.Core.Interfaces.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Models.Utilities
{
    public class BranchedConsumableUtility : IBranchedConsumableUtility, IEntity
    {

        public BranchedConsumableUtility(string name, UtilityType type, int indexMeter)
        {
            Name = name;
            Type = type;
            IndexMeter = indexMeter;
        }

        public BranchedConsumableUtility(string name)
        {
            Name = name;
        }

        public decimal AmountToPay { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public UtilityType Type { get; set; } = UtilityType.Consumable;
        public int IndexMeter { get; set; }
        public int CurrentMonthIndex { get; set; }
        public bool IsBranched { get; set; } = false;
        public Apartment Apartment { get; set; } = null!;
        public int ApartmentId { get; set; }

    }
}
