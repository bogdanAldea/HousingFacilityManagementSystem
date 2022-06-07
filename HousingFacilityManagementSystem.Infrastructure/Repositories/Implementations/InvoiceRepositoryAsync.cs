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
    public class InvoiceRepositoryAsync : IInvoiceRepository
    {

        private readonly HousingFacilityContext _context;

        public InvoiceRepositoryAsync(HousingFacilityContext context)
        {
            _context = context;
        }

        public async Task<Invoice> Get(int id)
        {
            return await _context.Invoices.FirstOrDefaultAsync(invoice => invoice.Id == id);
        }

        public async Task<IEnumerable<Invoice>> GetAllByApartment(int apartmentId)
        {
            return await _context.Invoices
                .Where(invoice => invoice.ApartmentId == apartmentId)
                .ToListAsync();
        }

        public async Task Post(Invoice invoice)
        {
            await _context.Invoices.AddAsync(invoice);
            await _context.SaveChangesAsync();
        }
    }
}
