using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Models.Utilities;
using HousingFacilityManagementSystem.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Infrastructure
{
    public class InMemoryUniversalUtilityRepository : IRepository<UniversalUtility>
    {

        private List<UniversalUtility> _universalUtilities;

        public InMemoryUniversalUtilityRepository(List<UniversalUtility> universalUtilities)
        {
            _universalUtilities = universalUtilities;
        }

        public void Add(UniversalUtility entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(UniversalUtility entity)
        {
            throw new NotImplementedException();
        }

        public ICollection<UniversalUtility> GetAll()
        {
            throw new NotImplementedException();
        }

        public UniversalUtility GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(UniversalUtility entity)
        {
            throw new NotImplementedException();
        }
    }
}
