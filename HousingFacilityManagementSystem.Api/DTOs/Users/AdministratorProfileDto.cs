using HousingFacilityManagementSystem.Core.Enums;
using HousingFacilityManagementSystem.Core.Models;

namespace HousingFacilityManagementSystem.Api.DTOs
{
    public class AdministratorProfileDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public UserRoles Role { get; set; }
        public BuildingDto Building { get; set; }
        public string IdentityId { get; set; }

    }
}
