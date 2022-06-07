using HousingFacilityManagementSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Repositories.Interfaces
{
    public interface IApartmentRepository
    {
        // GET Method will retrieve an apartment entity filtered by given id
        public Task<Apartment> Get(int id);

        // GET Method will retrieve an array of apartment entties filtered by the building they belong to
        public Task<ICollection<Apartment>> GetAllByBuilding(int buildingId);

        // PUT Method will update an existing apartment entity
        public Task Put(Apartment apartment);
    }
}
