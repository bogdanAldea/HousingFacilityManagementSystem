using System.ComponentModel.DataAnnotations;

namespace HousingFacilityManagementSystem.Api.DTOs
{
    public class UserRegistrationDto
    {
        [Required]
        [MinLength(3)]
        [MaxLength(25)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(25)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
    }
}
