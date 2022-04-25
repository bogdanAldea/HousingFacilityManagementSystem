using HousingFacilityManagementSystem.Core.Interfaces;
using HousingFacilityManagementSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Models
{
    public class Apartment : IEntity
    {

        public Apartment(int numberInBuilding)
        {
            NumberInBuilding = numberInBuilding;
        }

        public int Id { get; set; }
        public Tenant? Tenant { get; set; }
        public int? TenantId { get; set; }
        public int NumberInBuilding { get; set; }
        public int Residents { get; set; }
        public double SurfaceArea { get; set; }
        public ICollection<BranchedConsumableUtility> BranchedUtilities { get; set; } = new List<BranchedConsumableUtility>();
        public ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
        public double PaymentDebt { get; set; }
        public int BuildingId { get; set; }
    }
}