using HousingFacilityManagementSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Interfaces
{
    public interface IMasterConsumableUtility : IConsumable, IPriceable
    {
        public int Id { get; set; }
        public Utility Utility { get; set; }
    }
}
