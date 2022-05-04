using HousingFacilityManagementSystem.Application.Invoices.Queries;
using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Invoices.Handlers
{
    public class GetInvoicesByApartmentQueryHandler : IRequestHandler<GetInvoicesByApartmentQuery, List<Invoice>>
    {

        private readonly IRepository<Invoice> _repository;

        public GetInvoicesByApartmentQueryHandler(IRepository<Invoice> repository)
        {
            _repository = repository;
        }

        public async Task<List<Invoice>> Handle(GetInvoicesByApartmentQuery request, CancellationToken cancellationToken)
        {
            List<Invoice> invoices = _repository
                .GetAll()
                .Where(invoice => invoice.ApartmentId == request.ApartmentId)
                .ToList();

            return await Task.FromResult(invoices);
        }
    }
}
