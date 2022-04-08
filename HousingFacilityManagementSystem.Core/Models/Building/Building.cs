using HousingFacilityManagementSystem.Core.Interfaces;
using HousingFacilityManagementSystem.Core.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Models
{
    public class Building
    {

        public int Capacity { get; set; }
        public List<Apartment> Apartments { get; private set; } = new List<Apartment>();
        public List<MasterConsumableUtility> MasterPowerSupplies { get; set; } = new List<MasterConsumableUtility>();
        public List<UniversalUtility> CentralizedUtilities { get; set; } = new List<UniversalUtility>();

        public Building(int capacity)
        {
            Capacity = capacity;

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
