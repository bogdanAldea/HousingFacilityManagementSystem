using HousingFacilityManagementSystem.Core.Models;
using MediatR;


namespace HousingFacilityManagementSystem.Application.Apartments.Commands
{
    public class AddTenantCommand : IRequest<Apartment>
    {
        public int Id { get; set; }
        public int TenantId { get; set; }
    }
}
