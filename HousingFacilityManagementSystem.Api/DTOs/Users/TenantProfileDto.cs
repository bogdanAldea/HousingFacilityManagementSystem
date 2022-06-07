using HousingFacilityManagementSystem.Core.Enums;
using HousingFacilityManagementSystem.Core.Models;

namespace HousingFacilityManagementSystem.Api.DTOs
{
    public class TenantProfileDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserRoles Role { get; set; }
        public Apartment Apartment { get; set; }
        public string IdentityId { get; set; }
    }
}
