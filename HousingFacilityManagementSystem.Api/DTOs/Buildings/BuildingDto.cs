using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Models.Users;
using HousingFacilityManagementSystem.Core.Models.Utilities;

namespace HousingFacilityManagementSystem.Api.DTOs
{
    public class BuildingDto
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public int AdministratorId { get; set; }
        public ICollection<Apartment> Apartments { get; set; }
        public ICollection<MasterConsumableUtility> MasterConsumableUtilities { get; set; }
    }
}
