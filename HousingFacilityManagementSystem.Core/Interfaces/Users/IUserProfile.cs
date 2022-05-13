using HousingFacilityManagementSystem.Core.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Interfaces.Users
{
    public interface IUserProfile : IEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserRoles Role { get; set; }
        public IdentityUser Identity { get; set; }
        public string IdentityId { get; set; }
    }
}
