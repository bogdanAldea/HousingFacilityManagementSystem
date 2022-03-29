using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core
{
    public class Apartment
    {
        public Apartment(int affiliatedNumber, double surfaceArea)
        {
            AffiliatedNumber = affiliatedNumber;
            SurfaceArea = surfaceArea;
        }
        public int AffiliatedNumber { get; set; }
        public int NumberOfTenants { get; set; }
        public double SurfaceArea { get; set; }
        public PaymentBill UtilityBill { get; set; }
    }
}
