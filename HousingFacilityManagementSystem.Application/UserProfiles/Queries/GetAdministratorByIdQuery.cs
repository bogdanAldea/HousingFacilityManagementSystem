﻿using HousingFacilityManagementSystem.Core.Models.Users;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.UserProfiles.Queries
{
    public class GetAdministratorByIdQuery : IRequest<AdministratorProfile>
    {
        public int Id { get; set; }
    }
}
