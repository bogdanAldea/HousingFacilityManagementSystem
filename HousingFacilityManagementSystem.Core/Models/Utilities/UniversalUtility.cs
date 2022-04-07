using HousingFacilityManagementSystem.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Models
{
    public class UniversalUtility : IUniversalUtility
    {

        public UniversalUtility(Utility utility)
        {
            Utility = utility;
        }

        public Utility Utility { get; set; }
        public decimal Price { get; set; }
    }
}
