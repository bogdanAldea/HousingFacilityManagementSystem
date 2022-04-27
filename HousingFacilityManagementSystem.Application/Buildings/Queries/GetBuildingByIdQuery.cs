﻿using HousingFacilityManagementSystem.Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Buildings.Queries
{
    public class GetBuildingByIdQuery : IRequest<Building>
    {
        public int Id { get; set; }
    }
}
