using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Interfaces
{
    public interface IUtility
    {
        public string Name { get; set; }
        public ServiceProvider Provider { get; set; }
        public double CalculatePayment();
    }
}
