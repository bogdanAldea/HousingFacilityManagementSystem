using HousingFacilityManagementSystem.Core.Models;
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
    public class BuildingRepository : IRepository<Building>
    {

        private readonly HousingFacilityContext _context;

        public BuildingRepository(HousingFacilityContext context)
        {
            _context = context;
        }

        public void Add(Building entity)
        {
            _context.Buildings.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Building entity)
        {
            _context.Buildings.Remove(entity);
            _context.SaveChanges();
        }

        public ICollection<Building> GetAll()
        {
            return _context.Buildings
                .Include(building => building.Apartments)
                .Include(building => building.MasterConsumableUtilities)
                .ToList();
        }

        public Building GetById(int id)
        {
            return _context.Buildings
                .Include(building => building.Apartments)
                    .ThenInclude(apartment => apartment.BranchedUtilities)
                .Include(building => building.Apartments)
                    .ThenInclude(apartment => apartment.Invoices)   
                .Include(building => building.MasterConsumableUtilities)
                .SingleOrDefault(building => building.Id == id);
        }

        public void Update(Building entity)
        {
            var building = _context.Buildings.Where(building => building.Id == entity.Id).FirstOrDefault();
            _context.Entry(building).CurrentValues.SetValues(entity);
            _context.SaveChanges();
        }
    }
}
