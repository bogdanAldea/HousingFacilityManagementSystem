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
    public class InvoiceRepository : IRepository<Invoice>
    {

        private readonly HousingFacilityContext _context;

        public InvoiceRepository(HousingFacilityContext context)
        {
            _context = context;
        }

        public void Add(Invoice entity)
        {
            _context.Invoices.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Invoice entity)
        {
            _context.Invoices.Remove(entity);
            _context.SaveChanges();
        }

        public ICollection<Invoice> GetAll()
        {
            return _context.Invoices
                .ToList();
        }

        public Invoice GetById(int id)
        {
            return _context.Invoices.SingleOrDefault(invoice => invoice.Id == id);  
        }

        public void Update(Invoice entity)
        {
            Invoice oldInvoice = _context.Invoices.SingleOrDefault(invoice => invoice.Id == entity.Id);
            if (oldInvoice != null)
            {
                _context.Entry(oldInvoice).CurrentValues.SetValues(entity);
                _context.SaveChanges();
            }
        }
    }
}
