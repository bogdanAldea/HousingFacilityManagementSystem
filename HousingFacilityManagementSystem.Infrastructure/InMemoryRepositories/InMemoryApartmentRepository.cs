using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Infrastructure
{
    public class InMemoryApartmentRepository : IRepository<Apartment>
    {

        private List<Apartment> _apartments;

        public InMemoryApartmentRepository(List<Apartment> apartments)
        {
            _apartments = apartments;
        }

        public void Add(Apartment entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Apartment entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Apartment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Apartment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Apartment entity)
        {
            throw new NotImplementedException();
        }
    }
}
