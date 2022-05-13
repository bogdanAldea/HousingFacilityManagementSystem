using HousingFacilityManagementSystem.Core.Models.Users;
using HousingFacilityManagementSystem.Core.Repositories;
using HousingFacilityManagementSystem.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Infrastructure.Repositories
{
    public class AdminProfileRepository : IRepository<AdministratorProfile>
    {

        private readonly HousingFacilityContext _context;

        public AdminProfileRepository(HousingFacilityContext context)
        {
            _context = context;
        }

        public void Add(AdministratorProfile entity)
        {
            _context.Administrators.Add(entity);
            _context.SaveChanges();
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
                .SingleOrDefault(admin => admin.Id == id);
        }

        public AdministratorProfile GetByIdentityId(string id)
        {
            return _context.Administrators
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
