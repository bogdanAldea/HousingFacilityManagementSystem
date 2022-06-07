using HousingFacilityManagementSystem.Core.Models.Users;
using HousingFacilityManagementSystem.Core.Repositories.Interfaces;
using HousingFacilityManagementSystem.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Infrastructure.Repositories.Implementations
{
    public class AdministratorRepositoryAsync : IIdentityRepository<AdministratorProfile>
    {

        private readonly HousingFacilityContext _context;

        public AdministratorRepositoryAsync(HousingFacilityContext context)
        {
            _context = context;
        }

        public async Task AddIdentityProfile(AdministratorProfile identityProfile)
        {
            await _context.Administrators.AddAsync(identityProfile);
            await _context.SaveChangesAsync();
        }

        public DatabaseFacade Database()
        {
            return _context.Database;
        }

        public async Task<AdministratorProfile> GetByIdentityId(string identityId)
        {
            return await _context.Administrators
                .FirstOrDefaultAsync(profile => profile.IdentityId == identityId);
        }

        public async Task<AdministratorProfile> GetById(int id)
        {
            return await _context.Administrators
                .Include(admin => admin.Building).ThenInclude(building => building.Apartments)
                .Include(admin => admin.Building).ThenInclude(building => building.MasterConsumableUtilities)
                .FirstOrDefaultAsync(admin => admin.Id == id);  
        }
    }
}
