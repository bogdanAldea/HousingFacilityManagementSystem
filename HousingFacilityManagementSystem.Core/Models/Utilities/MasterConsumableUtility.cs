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
    public class MasterConsumableUtility : IMasterConsumableUtility, IEntity
    {

        public MasterConsumableUtility(string name, UtilityType type, decimal price, int indexMeter)
        {
            Name = name;
            Type = type;
            Price = price;
            IndexMeter = indexMeter;
        }

        public MasterConsumableUtility(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public UtilityType Type { get; set; } = UtilityType.Consumable;
        public int IndexMeter { get; set; }
        public int CurrentMonthIndex { get; set; }
        public decimal Price { get; set; }
    }
}
