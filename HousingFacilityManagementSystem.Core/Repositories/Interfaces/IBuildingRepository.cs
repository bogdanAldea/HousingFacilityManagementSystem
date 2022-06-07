using HousingFacilityManagementSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Repositories.Interfaces
{
    public interface IBuildingRepository
    {

        // Method that will retrieve the building associated with and administrator entity
        public Task<Building> GetById(int id);

        public Task<Building> GetByAdminId(int adminId);

        // Method that will post a new building entity to the database
        public Task Post(Building building);

        public Task Update(Building entity);

        public Task SaveChanges();

    }
}
