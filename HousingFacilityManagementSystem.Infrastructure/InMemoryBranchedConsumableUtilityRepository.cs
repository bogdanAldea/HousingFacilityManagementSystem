using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Infrastructure;

public class InMemoryBranchedConsumableUtilityRepository : IRepository<BranchedConsumableUtility>
{

    private List<BranchedConsumableUtility> _branchedUtilities;

    public InMemoryBranchedConsumableUtilityRepository(List<BranchedConsumableUtility> branchedUtilities)
    {
        _branchedUtilities = branchedUtilities;
    }

    public void Add(BranchedConsumableUtility entity)
    {
        if (entity == null)
        {
            throw new ArgumentNullException();
        }

        entity.Id = _branchedUtilities.Count();
        _branchedUtilities.Add(entity);
    }

    public void Delete(BranchedConsumableUtility entity)
    {
        _branchedUtilities.Remove(entity);
    }

    public IEnumerable<BranchedConsumableUtility> GetAll()
    {
        return _branchedUtilities;
    }

    public BranchedConsumableUtility GetById(int id)
    {
        return _branchedUtilities.FirstOrDefault(utility => utility.Id == id);
    }

    public void Update(BranchedConsumableUtility entity)
    {
        throw new NotImplementedException();
    }
}
