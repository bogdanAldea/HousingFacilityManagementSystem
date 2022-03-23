using HousingFacilityManagementSystem.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core
{
    public class CentralizedGeneralUtility : IUtility
    {
        public CentralizedGeneralUtility(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public ServiceProvider Provider { get; set; }

        public double CalculatePayment()
        {
            throw new NotImplementedException();
        }
    }
}
