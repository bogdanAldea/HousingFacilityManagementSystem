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
    public class BuildingRepositoryAsync : IBuildingRepository
    {

        private readonly HousingFacilityContext _context;

        public BuildingRepositoryAsync(HousingFacilityContext context)
        {
            _context = context;
        }

        public async Task<Building> GetById(int id)
        {
            return await _context.Buildings
                .Include(building => building.Apartments)
                .Include(building => building.MasterConsumableUtilities)
                .FirstOrDefaultAsync(building => building.Id == id);
        }

        public async Task<Building> GetByAdminId(int adminId)
        {
            return await _context.Buildings
                .Include(building => building.Apartments)
                .Include(building => building.MasterConsumableUtilities)
                .FirstOrDefaultAsync(building => building.AdministratorId == adminId);
        }

        public async Task Post(Building building)
        {
            await _context.Buildings.AddAsync(building);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Building entity)
        {
            Building oldBuilding = await _context.Buildings.SingleOrDefaultAsync(util => util.Id == entity.Id);

            if (oldBuilding != null)
            {
                _context.Entry(oldBuilding).CurrentValues.SetValues(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task SaveChanges() { await _context.SaveChangesAsync(); }
    }
}
