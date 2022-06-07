using System.ComponentModel.DataAnnotations;

namespace HousingFacilityManagementSystem.Api.DTOs
{
    public class UserLoginDto
    {

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
