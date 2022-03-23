using HousingFacilityManagementSystem.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core
{
    public class ActivatablePowerSupply : IActivatablePowerSupply
    {
        public ActivatablePowerSupply(string name, int indexMeter)
        {
            Name = name;
            IndexMeter = indexMeter;
        }

        public string Name { get; set; }
        public int IndexMeter { get; set; }
        public int CurrentConsumptioIndex { get; set; }
        public bool IsActive { get; set; }
        public ServiceProvider Provider { get; set; }

        public double CalculatePayment()
        {
            throw new NotImplementedException();
        }
    }
}
