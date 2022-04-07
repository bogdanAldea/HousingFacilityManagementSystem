using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Infrastructure
{
    public class InMemoryAddressRepository : IRepository<Address>
    {

        private List<Address> _addresses;

        public InMemoryAddressRepository(List<Address> addresses)
        {
            _addresses = addresses;
        }

        public void Add(Address entity)
        {
            if (entity == null) { throw new ArgumentNullException(); }
            _addresses.Add(entity);
        }

        public void Delete(Address entity)
        {
            _addresses.Remove(entity);
        }

        public IEnumerable<Address> GetAll()
        {
            return _addresses;
        }

        public Address GetById(int id)
        {
            return _addresses.FirstOrDefault(address => address.Id == id);
        }

        public void Update(Address entity)
        {
            throw new NotImplementedException();
        }
    }
}
