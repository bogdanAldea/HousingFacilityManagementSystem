using HousingFacilityManagementSystem.Core.Models;

namespace HousingFacilityManagementSystem.Api.DTOs
{
    public class BuildingDto
    {
        public int Capacity { get; set; }
        public Administrator Administrator { get; set; }
        public ICollection<Apartment> Apartments { get; set; }
        public ICollection<MasterConsumableUtility> MasterConsumableUtilities { get; set; }
    }
}
