using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Models.Utilities;
using HousingFacilityManagementSystem.Core.Repositories.Interfaces;
using HousingFacilityManagementSystem.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Services
{
    public class BuildingService : IBuildingService
    {
        private readonly IBuildingRepository _repository;

        public BuildingService(IBuildingRepository repository)
        {
            _repository = repository;
        }

        public async Task<Building> CreateBuilding(int capacity, int administratorId, List<MasterConsumableUtility> utilities)
        {
            Building building = new Building(capacity: capacity)
            {
                AdministratorId = administratorId,
                MasterConsumableUtilities = utilities
            };

            building.AddApartments();
            AssignBranchedUtilsToApartment(building);
            await _repository.Post(building);
            return building;
        }

        public void AssignBranchedUtilsToApartment(Building building)
        {
            foreach (var apartment in building.Apartments)
            {
                List<BranchedConsumableUtility> branchedUtilities = building.MasterConsumableUtilities
                    .Select(utility => new BranchedConsumableUtility(name: utility.Name))
                    .ToList();

                apartment.BranchedUtilities = branchedUtilities;
            }
        }

    }
}
