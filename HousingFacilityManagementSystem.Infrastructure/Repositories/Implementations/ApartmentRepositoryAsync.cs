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
    public class ApartmentRepositoryAsync : IApartmentRepository
    {

        private readonly HousingFacilityContext _context;

        public ApartmentRepositoryAsync(HousingFacilityContext context)
        {
            _context = context;
        }

        public async Task<Apartment> Get(int id)
        {
            return await _context.Apartments
                .Include(apartment => apartment.Invoices)
                .Include(apartment => apartment.BranchedUtilities)
                .FirstOrDefaultAsync(apartment => apartment.Id == id);
        }

        public async Task<ICollection<Apartment>> GetAllByBuilding(int buildingId)
        {
            return await _context.Apartments
                .Include(apartment => apartment.Invoices)
                .Include(apartment => apartment.BranchedUtilities)
                .Where(apartment => apartment.BuildingId == buildingId)
                .ToListAsync();
        }

        public async Task Put(Apartment apartment)
        {
            Apartment oldApartment = await _context.Apartments
                .FirstAsync(response => response.Id == apartment.Id);
            _context.Entry(oldApartment).CurrentValues.SetValues(apartment);
            await _context.SaveChangesAsync();
        }
    }
}
