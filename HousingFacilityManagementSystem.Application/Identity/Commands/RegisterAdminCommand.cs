using HousingFacilityManagementSystem.Application.Identity.DTOs;
using HousingFacilityManagementSystem.Application.Options;
using HousingFacilityManagementSystem.Core.Models.Users;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Identity.Commands
{
    public class RegisterAdminCommand : IRequest<OperationResult<AdministratorProfile>>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
    }
}
