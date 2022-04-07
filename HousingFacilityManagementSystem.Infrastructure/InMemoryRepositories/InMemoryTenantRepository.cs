using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Infrastructure
{
    public class InMemoryTenantRepository : IRepository<Tenant>
    {

        private List<Tenant> _tenants;

        public InMemoryTenantRepository(List<Tenant> tenants)
        {
            _tenants = tenants;
        }

        public void Add(Tenant entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Tenant entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tenant> GetAll()
        {
            throw new NotImplementedException();
        }

        public Tenant GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Tenant entity)
        {
            throw new NotImplementedException();
        }
    }
}
