using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Repositories;
using HousingFacilityManagementSystem.Infrastructure.Context;


namespace HousingFacilityManagementSystem.Infrastructure.Repositories
{
    public class BranchedUtilityRepository : IRepository<BranchedConsumableUtility>
    {

        private readonly HousingFacilityContext _context;

        public BranchedUtilityRepository(HousingFacilityContext context)
        {
            _context = context;
        }

        public void Add(BranchedConsumableUtility entity)
        {
            _context.BranchedConsumableUtilities.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(BranchedConsumableUtility entity)
        {
            _context.BranchedConsumableUtilities.Remove(entity);
            _context.SaveChanges();
        }

        public ICollection<BranchedConsumableUtility> GetAll()
        {
            return _context.BranchedConsumableUtilities.ToList();
        }

        public BranchedConsumableUtility GetById(int id)
        {
            return _context.BranchedConsumableUtilities.SingleOrDefault(util => util.Id == id); 
        }

        public void Update(BranchedConsumableUtility entity)
        {
            BranchedConsumableUtility oldUtil = _context.BranchedConsumableUtilities.SingleOrDefault(util => util.Id == entity.Id); 

            if (oldUtil != null)
            {
                _context.Entry(oldUtil).CurrentValues.SetValues(entity);
                _context.SaveChanges();
            }
        }
    }
}
