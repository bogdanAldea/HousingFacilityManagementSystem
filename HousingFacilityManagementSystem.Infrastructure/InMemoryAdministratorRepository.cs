using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Infrastructure
{
    public class InMemoryAdministratorRepository : IRepository<Administrator>
    {

        private readonly IRepository<Administrator> _repository;
        public void Add(Administrator entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Administrator entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Administrator> GetAll()
        {
            throw new NotImplementedException();
        }

        public Administrator GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Administrator entity)
        {
            throw new NotImplementedException();
        }
    }
}
