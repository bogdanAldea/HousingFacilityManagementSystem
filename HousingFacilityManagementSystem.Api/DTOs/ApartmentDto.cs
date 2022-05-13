using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Models.Users;

namespace HousingFacilityManagementSystem.Api.DTOs
{
    public class ApartmentDto
    {
        public TenantProfile Tenant { get; set; }
        public int Residents { get; set; }
        public double SurfaceArea { get; set; }
        public decimal PaymentDebt { get; set; }
        public ICollection<BranchedConsumableUtility> BranchedConsumableUtilities { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
        public int BuildingId { get; set; }
    }
}
