using HousingFacilityManagementSystem.Core.Enums;
using HousingFacilityManagementSystem.Core.Models;

namespace HousingFacilityManagementSystem.Api.DTOs
{
    public class AdministratorProfileDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserRoles Role { get; set; }
        public Building Building { get; set; }
        public string IdentityId { get; set; }
    }
}
