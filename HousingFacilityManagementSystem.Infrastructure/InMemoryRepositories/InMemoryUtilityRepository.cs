using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Infrastructure
{
    internal class InMemoryUtilityRepository : IRepository<Utility>
    {

        private List<Utility> _utilities;

        public InMemoryUtilityRepository(List<Utility> utilities)
        {
            _utilities = utilities;
        }

        public void Add(Utility entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Utility entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Utility> GetAll()
        {
            throw new NotImplementedException();
        }

        public Utility GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Utility entity)
        {
            throw new NotImplementedException();
        }
    }
}
