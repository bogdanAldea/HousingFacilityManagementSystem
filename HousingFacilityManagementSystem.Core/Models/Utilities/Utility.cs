using HousingFacilityManagementSystem.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Models
{
    public class Utility
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public UtilityType UtilityType { get; set; }


        public Utility(string name, UtilityType utilityType)
        {
            Name = name;
            UtilityType = utilityType;
        }
    }
}
