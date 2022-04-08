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
            if (entity == null) { throw new ArgumentNullException(); }
            entity.Id = _apartments.Count();
        }

        public void Delete(Apartment entity)
        {
            _apartments.Remove(entity);
        }

        public IEnumerable<Apartment> GetAll()
        {
            return _apartments;
        }

        public Apartment GetById(int id)
        {
            return _apartments.FirstOrDefault(apartment => apartment.Id == id);
        }

        public void Update(Apartment entity)
        {
            throw new NotImplementedException();
        }
    }
}
