using HousingFacilityManagementSystem.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Interfaces.Utilities
{
    public interface IUtility
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public UtilityType Type { get; set; }
    }
}
