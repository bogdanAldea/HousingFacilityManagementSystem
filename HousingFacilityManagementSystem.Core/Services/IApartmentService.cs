using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Services
{
    public interface IApartmentService
    {
        public void CreateAparment(int numberInBuilding);
        public void SetNumberOfResidents(int apartmentId, int numberOfResidents);
        public void SetSurfaceArea(int apartmentId, double surfaceArea);
        public void SetTenant(int apartmentId, Tenant tenant);
    }
}
