using HousingFacilityManagementSystem.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Models
{
    public class MasterConsumableUtility : IMasterConsumableUtility
    {

        public MasterConsumableUtility(Utility utility, int indexMeter)
        {
            Utility = utility;
            IndexMeter = indexMeter;
        }

        public int Id { get; set; }
        public int IndexMeter { get; set; }
        public int CurrentMonthIndex { get; set; }
        public decimal Price { get; set; }
        public Utility Utility { get; set; }

        public override string ToString()
        {
            return $"Utility: {Utility.Name}({IndexMeter})";
        }

    }
}
