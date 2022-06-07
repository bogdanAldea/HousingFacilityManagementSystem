using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Models.Utilities;
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
    public class MasterUtilityRepositoryAsync : IMasterUtilityRepository
    {

        private readonly HousingFacilityContext _context;

        public MasterUtilityRepositoryAsync(HousingFacilityContext context)
        {
            _context = context;
        }

        public async Task<MasterConsumableUtility> Get(int id)
        {
            return await _context.MasterConsumableUtilities
                .FirstOrDefaultAsync(utility => utility.Id == id);
        }

        public async Task<ICollection<MasterConsumableUtility>> GetAllByBuilding(int buildingId)
        {
            return await _context.MasterConsumableUtilities
                .Where(utility => utility.BuildingId == buildingId)
                .ToListAsync();
        }

        public async Task<MasterConsumableUtility> GetByName(string name)
        {
            return await _context.MasterConsumableUtilities
                .FirstOrDefaultAsync(utility => utility.Name == name);
        }

        public async Task Put(MasterConsumableUtility utility)
        {
            MasterConsumableUtility oldUtility = _context.MasterConsumableUtilities.First(entity => entity.Id == utility.Id);
            _context.Entry(oldUtility).CurrentValues.SetValues(utility);
            await _context.SaveChangesAsync();
        }
    }
}
