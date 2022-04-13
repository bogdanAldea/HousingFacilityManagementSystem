using HousingFacilityManagementSystem.Core.Models.Utilities;
using HousingFacilityManagementSystem.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Infrastructure
{
    public class InMemoryMasterConsumableUtilityRepository : IRepository<MasterConsumableUtility>
    {
        private List<MasterConsumableUtility> _masterConsumableUtilities;

        public InMemoryMasterConsumableUtilityRepository(List<MasterConsumableUtility> masterUtilities)
        {
            _masterConsumableUtilities = masterUtilities;
        }

        public void Add(MasterConsumableUtility entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }

            entity.Id = _masterConsumableUtilities.Count();
            _masterConsumableUtilities.Add(entity);
        }

        public void Delete(MasterConsumableUtility entity)
        {
            _masterConsumableUtilities.Remove(entity);
        }

        public ICollection<MasterConsumableUtility> GetAll()
        {
            return _masterConsumableUtilities;
        }

        public MasterConsumableUtility GetById(int id)
        {
            return _masterConsumableUtilities.FirstOrDefault(utility => utility.Id == id);
        }

        public void Update(MasterConsumableUtility entity)
        {
            throw new NotImplementedException();
        }
    }
}
