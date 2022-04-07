using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Infrastructure
{
    public class InMemoryInvoiceRepository : IRepository<Invoice>
    {

        private List<Invoice> _invoices;

        public InMemoryInvoiceRepository(List<Invoice> invoices)
        {
            _invoices = invoices;
        }

        public void Add(Invoice entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Invoice entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Invoice> GetAll()
        {
            throw new NotImplementedException();
        }

        public Invoice GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Invoice entity)
        {
            throw new NotImplementedException();
        }
    }
}
