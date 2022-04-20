using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HousingFacilityManagementSystem.Core.Models;


namespace HousingFacilityManagementSystem.Application.Apartments.Queries
{
    public class GetApartmentByIdQuery : IRequest<Apartment>
    {
        public int Id { get; set; }

        public GetApartmentByIdQuery(int id)
        {
            Id = id;
        }
    }
}
