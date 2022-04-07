using HousingFacilityManagementSystem.Core.Models;
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
        private List<MasterConsumableUtility> _masterConsumableUtilityList;

        public InMemoryMasterConsumableUtilityRepository(List<MasterConsumableUtility> masterUtilities)
        {
            _masterConsumableUtilityList = masterUtilities;
        }

        public void Add(MasterConsumableUtility entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException();
            }

            entity.Id = _masterConsumableUtilityList.Count();
            _masterConsumableUtilityList.Add(entity);
        }

        public void Delete(MasterConsumableUtility entity)
        {
            _masterConsumableUtilityList.Remove(entity);
        }

        public IEnumerable<MasterConsumableUtility> GetAll()
        {
            return _masterConsumableUtilityList;
        }

        public MasterConsumableUtility GetById(int id)
        {
            return _masterConsumableUtilityList.FirstOrDefault(utility => utility.Id == id);
        }

        public void Update(MasterConsumableUtility entity)
        {
            throw new NotImplementedException();
        }
    }
}
