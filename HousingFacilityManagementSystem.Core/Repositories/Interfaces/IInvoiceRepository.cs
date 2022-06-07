using HousingFacilityManagementSystem.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Core.Repositories.Interfaces
{
    public interface IInvoiceRepository
    {
        public Task<Invoice> Get(int id);
        public Task<IEnumerable<Invoice>> GetAllByApartment(int apartmentId);
        public Task Post(Invoice invoice);
    }
}
