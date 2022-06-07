using HousingFacilityManagementSystem.Core.Interfaces;
using HousingFacilityManagementSystem.Core.Models.Users;
using HousingFacilityManagementSystem.Core.Repositories;
using HousingFacilityManagementSystem.Infrastructure.Context;
using HousingFacilityManagementSystem.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;


namespace HousingFacilityManagementSystem.Infrastructure.Repositories
{
    public class AdminIdentityRepository : IIdentityRepository<AdministratorProfile>
    {

        private readonly HousingFacilityContext _context;

        public AdminIdentityRepository(HousingFacilityContext context)
        {
            _context = context;
        }

        public void Add(AdministratorProfile entity)
        {
            _context.Administrators.Add(entity);
            _context.SaveChanges();
        }

        public DatabaseFacade Database()
        {
            return _context.Database;
        }

        public void Delete(AdministratorProfile entity)
        {
            _context.Administrators.Remove(entity);
            _context.SaveChanges();
        }

        public ICollection<AdministratorProfile> GetAll()
        {
            return _context.Administrators
                           .ToList();
        }

        public AdministratorProfile GetById(int id)
        {
            return _context.Administrators
                .Include(admin => admin.Building)
                    .ThenInclude(building => building.MasterConsumableUtilities)
                .Include(admin => admin.Building)
                    .ThenInclude(building => building.Apartments)
                .SingleOrDefault(admin => admin.Id == id);
        }

        public AdministratorProfile GetByIdentityId(string id)
        {
            return _context.Administrators
                .Include(admin => admin.Identity)
                .Include(admin => admin.Building)
                .SingleOrDefault(admin => admin.IdentityId == id);
        }

        public void Update(AdministratorProfile entity)
        {
            AdministratorProfile? existingAdminProfile = _context.Administrators
                .SingleOrDefault(admin => admin.Id == entity.Id);

            if (existingAdminProfile != null)
            {
                _context.Entry(existingAdminProfile).CurrentValues.SetValues(entity);
                _context.SaveChanges();
            }
        }
    }
}