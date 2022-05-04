using HousingFacilityManagementSystem.Core.Interfaces;
using HousingFacilityManagementSystem.Core.Models;
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
        public int? AdministratorId { get; set; }
        public int Capacity { get; set; }
        public ICollection<Apartment> Apartments { get; private set; } = new List<Apartment>();
        public ICollection<MasterConsumableUtility> MasterConsumableUtilities { get; set; } = new List<MasterConsumableUtility>();

        public Building(int capacity)
        {
            Capacity = capacity;
        }

        public void AddApartments()
        {
            if (Apartments.Count == Capacity) { throw new InvalidOperationException(); }
            for (int apartmentNumber = 0; apartmentNumber < Capacity; apartmentNumber++)
            {

                Apartment apartment = new Apartment(numberInBuilding: apartmentNumber + 1);
                Apartments.Add(apartment);
            }
        }

    }
}
