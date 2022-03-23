using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Interfaces
{
    public interface IActivatable
    {
        public bool IsActive { get; set; }
    }
}
