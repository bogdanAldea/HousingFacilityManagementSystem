using HousingFacilityManagementSystem.Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Buildings.Commands
{
    public class CreateBuildingCommand : IRequest<Building>
    {
        public CreateBuildingCommand(int capacity)
        {
            Capacity = capacity;
        }
        public int Capacity { get; set; }
    }
}
