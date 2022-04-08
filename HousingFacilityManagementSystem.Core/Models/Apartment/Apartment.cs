using HousingFacilityManagementSystem.Core.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Models
{
    public class Apartment
    {

        public Apartment(int numberInBuilding, Tenant tenant)
        {
            NumberInBuilding = numberInBuilding;
            Tenant = tenant;
        }

        public int Id { get; set; }
        public Tenant Tenant { get; set; }
        public int NumberInBuilding { get; set; }
        public int Residents { get; set; }
        public double SurfaceArea { get; set; }
        public List<BranchedConsumableUtility> PowerSupplies { get; set; } = new List<BranchedConsumableUtility>();
        public List<Invoice> Invoices { get; set; } = new List<Invoice>();
        public double PaymentDebt { get; set; }
    }
}
