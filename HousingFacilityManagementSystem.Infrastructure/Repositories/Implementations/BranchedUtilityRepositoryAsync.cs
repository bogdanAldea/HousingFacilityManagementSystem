using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Repositories.Interfaces;
using HousingFacilityManagementSystem.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Infrastructure.Repositories.Implementations
{
    public class BranchedUtilityRepositoryAsync : IBranchedUtilityRepository
    {

        private readonly HousingFacilityContext _context;

        public BranchedUtilityRepositoryAsync(HousingFacilityContext context)
        {
            _context = context;
        }

        public async Task<BranchedConsumableUtility> Get(int id)
        {
            return await _context.BranchedConsumableUtilities
                .FirstOrDefaultAsync(utility => utility.Id == id);
        }

        public async Task<IEnumerable<BranchedConsumableUtility>> GetAllByBuilding(int buildingId)
        {
            return await _context.BranchedConsumableUtilities
                            .Where(utility => utility.ApartmentId == buildingId)
                            .ToListAsync();
        }

        public async Task Put(BranchedConsumableUtility utility)
        {
            BranchedConsumableUtility olUtility =  _context.BranchedConsumableUtilities.First(entity => entity.Id == utility.Id);
            _context.Entry(olUtility).CurrentValues.SetValues(utility);
            await _context.SaveChangesAsync();
        }
    }
}
