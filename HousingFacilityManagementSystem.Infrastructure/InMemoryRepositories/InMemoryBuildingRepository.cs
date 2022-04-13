using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Infrastructure
{
    public class InMemoryBuildingRepository : IRepository<Building>
    {

        private List<Building> _buildings;

        public InMemoryBuildingRepository(List<Building> buildings)
        {
            _buildings = buildings;
        }

        public void Add(Building entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Building entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<Building> GetAll()
        {
            throw new NotImplementedException();
        }

        public Building GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Building entity)
        {
            throw new NotImplementedException();
        }
    }
}
