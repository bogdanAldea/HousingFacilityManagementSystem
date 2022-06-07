using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Models.Users;

namespace HousingFacilityManagementSystem.Api.DTOs
{
    public class ApartmentDto
    {
        public int Id { get; set; }
        public int NumberInBuilding { get; set; }
        public TenantProfile Tenant { get; set; }
        public int Residents { get; set; }
        public double SurfaceArea { get; set; }
        public decimal PaymentDebt { get; set; }
        public ICollection<BranchedConsumableUtility> BranchedUtilities { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
        public int BuildingId { get; set; }
    }
}
