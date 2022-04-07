using Project.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Models
{
    public class Building
    {

        public Address Address { get; set; }
        public int Capacity { get; set; }
        public List<Apartment> Apartments { get; private set; } = new List<Apartment>();
        public List<IMasterPowerSupply> MasterPowerSupplies { get; set; } = new List<IMasterPowerSupply>();
        public List<ICentralizedUtility> CentralizedUtilities { get; set; } = new List<ICentralizedUtility>();

        public Building(int capacity, Address address)
        {
            Capacity = capacity;
            Address = address;

            CreateApartments();
        }

        private void CreateApartments()
        {
            for (int apartmentNumber = 0; apartmentNumber < Capacity; apartmentNumber++)
            {

                Apartment apartment = new Apartment(numberInBuilding: apartmentNumber + 1);
                Apartments.Add(apartment);
            }
        }

    }
}
