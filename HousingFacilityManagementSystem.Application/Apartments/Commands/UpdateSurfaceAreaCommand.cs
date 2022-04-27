using HousingFacilityManagementSystem.Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Apartments.Commands
{
    public class UpdateSurfaceAreaCommand : IRequest<Apartment>
    {
        public int Id { get; set; }
        public double SurfaceArea { get; set; }
    }
}
