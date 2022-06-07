using HousingFacilityManagementSystem.Application.Options;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Identity.Commands
{
    public class LoginAdminCommand : IRequest<OperationResult<string>>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
