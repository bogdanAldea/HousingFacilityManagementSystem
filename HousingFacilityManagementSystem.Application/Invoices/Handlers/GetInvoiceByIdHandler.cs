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
    public class GetInvoiceByIdHandler : IRequestHandler<GetInvoiceByIdQuery, Invoice>
    {

        private readonly IRepository<Invoice> _repository;

        public GetInvoiceByIdHandler(IRepository<Invoice> repository)
        {
            _repository = repository;   
        }

        public async Task<Invoice> Handle(GetInvoiceByIdQuery request, CancellationToken cancellationToken)
        {
            Invoice invoice = _repository.GetById(id: request.Id);
            return await Task.FromResult(invoice);
        }
    }
}
