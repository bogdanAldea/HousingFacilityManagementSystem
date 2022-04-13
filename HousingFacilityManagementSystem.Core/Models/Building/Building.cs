using HousingFacilityManagementSystem.Core.Interfaces;
using HousingFacilityManagementSystem.Core.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Models
{
    public class Building : IEntity
    {
        public int Id { get; set; }
        public Administrator? Administrator { get; set; } = null!;
        public int Capacity { get; set; }
        public List<Apartment> Apartments { get; private set; } = new List<Apartment>();
        public List<MasterConsumableUtility> MasterConsumableUtilities { get; set; } = new List<MasterConsumableUtility>();
        public List<UniversalUtility> UniversalUtilities { get; set; } = new List<UniversalUtility>();

        public Building(int capacity, Administrator administrator)
        {
            Capacity = capacity;
            Administrator = administrator;

        }

        public Building()
        {

        }

        public void CreateApartments()
        {
            for (int apartmentNumber = 0; apartmentNumber < Capacity; apartmentNumber++)
            {

                Apartment apartment = new Apartment(numberInBuilding: apartmentNumber + 1);
                Apartments.Add(apartment);
            }
        }

    }
}
