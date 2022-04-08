using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Interfaces
{
    public interface IConsumable
    {
        public int IndexMeter { get; set; }
        public int CurrentMonthIndex { get; set; }
    }
}
