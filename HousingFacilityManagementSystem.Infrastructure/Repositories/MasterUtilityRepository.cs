using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Models.Utilities;
using HousingFacilityManagementSystem.Core.Repositories;
using HousingFacilityManagementSystem.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Infrastructure.Repositories
{
    public class MasterUtilityRepository : IRepository<MasterConsumableUtility>
    {

        private readonly HousingFacilityContext _context;

        public MasterUtilityRepository(HousingFacilityContext context)
        {
            _context = context;
        }

        public void Add(MasterConsumableUtility entity)
        {
            _context.MasterConsumableUtilities.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(MasterConsumableUtility entity)
        {
            _context.MasterConsumableUtilities.Remove(entity);
            _context.SaveChanges();
        }

        public ICollection<MasterConsumableUtility> GetAll()
        {
            return _context.MasterConsumableUtilities.ToList();
        }

        public MasterConsumableUtility GetById(int id)
        {
            return _context.MasterConsumableUtilities
                .SingleOrDefault(util => util.Id == id);
        }

        public void Update(MasterConsumableUtility entity)
        {
            _context.MasterConsumableUtilities.Update(entity);
            _context.SaveChanges();
        }
    }
}
