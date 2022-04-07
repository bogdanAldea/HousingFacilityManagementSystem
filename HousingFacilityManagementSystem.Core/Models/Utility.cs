using HousingFacilityManagementSystem.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
    public class Utility
    {

        public Utility(string name, UtilityType utilityType)
        {
            Name = name;
            UtilityType = utilityType;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public UtilityType UtilityType { get; set; }

    }
}
