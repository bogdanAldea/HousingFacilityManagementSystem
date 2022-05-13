using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Models.Users;

namespace HousingFacilityManagementSystem.Api.DTOs
{
    public class BuildingDto
    {
        public int Capacity { get; set; }
        public AdministratorProfile Administrator { get; set; }
        public ICollection<Apartment> Apartments { get; set; }
        public ICollection<MasterConsumableUtility> MasterConsumableUtilities { get; set; }
    }
}
