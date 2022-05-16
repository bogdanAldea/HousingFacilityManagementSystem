using HousingFacilityManagementSystem.Core.Models.Users;
using HousingFacilityManagementSystem.Infrastructure.Context;
using HousingFacilityManagementSystem.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Infrastructure.Repositories
{
    internal class TenantIdentityRepository : IIdentityRepository<TenantProfile>
    {

        private readonly HousingFacilityContext _context;

        public TenantIdentityRepository(HousingFacilityContext context)
        {
            _context = context;
        }

        public void Add(TenantProfile entity)
        {
            _context.Tenants.Add(entity);
            _context.SaveChanges();
        }

        public DatabaseFacade Database()
        {
            return _context.Database;
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
                .Include(admin => admin.Identity.Email)
                .Include(admin => admin.Identity.UserName)
                .Include(admin => admin.Identity.PhoneNumber)
                .Include(admin => admin.Apartment)
                .SingleOrDefault(admin => admin.Id == id);
        }

        public TenantProfile GetByIdentityId(string id)
        {
            return _context.Tenants
                .Include(admin => admin.Identity)
                .Include(admin => admin.Apartment)
                .SingleOrDefault(admin => admin.IdentityId == id);
        }

        public void Update(TenantProfile entity)
        {
            TenantProfile? existingAdminProfile = _context.Tenants
                .SingleOrDefault(admin => admin.Id == entity.Id);

            if (existingAdminProfile != null)
            {
                _context.Entry(existingAdminProfile).CurrentValues.SetValues(entity);
                _context.SaveChanges();
            }
        }
    }
}