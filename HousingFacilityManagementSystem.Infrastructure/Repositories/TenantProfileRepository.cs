using HousingFacilityManagementSystem.Core.Models.Users;
using HousingFacilityManagementSystem.Core.Repositories;
using HousingFacilityManagementSystem.Infrastructure.Context;

namespace HousingFacilityManagementSystem.Infrastructure.Repositories
{
    public class TenantProfileRepository : IRepository<TenantProfile>
    {

        private readonly HousingFacilityContext _context;

        public TenantProfileRepository(HousingFacilityContext context)
        {
            _context = context;
        }

        public void Add(TenantProfile entity)
        {
            _context.Tenants.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(TenantProfile entity)
        {
            _context.Tenants.Remove(entity);
            _context.SaveChanges();
        }

        public ICollection<TenantProfile> GetAll()
        {
            return _context.Tenants
                .ToList();
        }

        public TenantProfile GetById(int id)
        {
            return _context.Tenants
                .SingleOrDefault(tenant => tenant.Id == id);
        }

        public TenantProfile GetByIdentityId(string id)
        {
            return _context.Tenants
                .SingleOrDefault(admin => admin.IdentityId == id);
        }

        public void Update(TenantProfile entity)
        {
            TenantProfile? existingTenantProfile = _context.Tenants
                .SingleOrDefault(tenant => tenant.Id == entity.Id);

            if (existingTenantProfile != null)
            {
                _context.Entry(existingTenantProfile).CurrentValues.SetValues(entity);
                _context.SaveChanges();
            }
        }
    }
}
