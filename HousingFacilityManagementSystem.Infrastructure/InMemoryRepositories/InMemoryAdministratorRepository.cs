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

        private List<Administrator> _administrators;

        public InMemoryAdministratorRepository(List<Administrator> administrators)
        {
            _administrators = administrators;
        }

        public void Add(Administrator entity)
        {
            if (entity == null) { throw new ArgumentNullException(); }
            entity.Id = _administrators.Count();
        }

        public void Delete(Administrator entity)
        {
            _administrators.Remove(entity);
        }

        public ICollection<Administrator> GetAll()
        {
            return _administrators;
        }

        public Administrator GetById(int id)
        {
            return _administrators.FirstOrDefault(administrator => administrator.Id == id);
        }

        public void Update(Administrator entity)
        {
            throw new NotImplementedException();
        }
    }
}
