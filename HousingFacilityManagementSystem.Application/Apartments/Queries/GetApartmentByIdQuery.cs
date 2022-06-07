using HousingFacilityManagementSystem.Application.Options;
using HousingFacilityManagementSystem.Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Apartments.Queries
{
    public class GetApartmentByIdQuery : IRequest<OperationResult<Apartment>>
    {
        public int Id { get; set; }
    }
}
