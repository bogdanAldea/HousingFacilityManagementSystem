using HousingFacilityManagementSystem.Core.Enums;
using HousingFacilityManagementSystem.Core.Interfaces.Users;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Models.Users
{
    public class AdministratorProfile : IUserProfile
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string PhoneNumber { get; set; }
        public UserRoles Role { get; set; } = UserRoles.Admin;
        public Building Building { get; set; }
        public IdentityUser Identity { get; set; }
        public string IdentityId { get; set; }
        public int Id { get; set; }
    }
}
