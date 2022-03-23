using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core
{
    public class Building
    {
        public Building(int apartmentCapacity, Address address)
        {
            ApartmentCapacity = apartmentCapacity;
            Address = address;
        }

        public Address Address { get; set; }
        public int ApartmentCapacity { get; set; }
        public PaymentBill UtilityBill { get; set; }
    }
}
