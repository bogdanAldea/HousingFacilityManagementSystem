using HousingFacilityManagementSystem.Core.Enums;
using HousingFacilityManagementSystem.Core.Interfaces.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Models.Utilities
{
    public class UniversalUtility : IUniversalUtility
    {

        public UniversalUtility(string name, UtilityType type, decimal price)
        {
            Name = name;
            Type = type;
            Price = price;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public UtilityType Type { get; set; }
    }
}
