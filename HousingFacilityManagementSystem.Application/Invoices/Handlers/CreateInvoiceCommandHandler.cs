using HousingFacilityManagementSystem.Application.Invoices.Commands;
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
    public class CreateInvoiceCommandHandler : IRequestHandler<CreateInvoiceCommand, Invoice>
    {

        private readonly IRepository<Invoice> _repository;

        public CreateInvoiceCommandHandler(IRepository<Invoice> repository)
        {
            _repository = repository;   
        }

        public async Task<Invoice> Handle(CreateInvoiceCommand request, CancellationToken cancellationToken)
        {
            Invoice invoice = new Invoice { 
                ApartmentId = request.ApartmentId,
                Number = request.Number,
                Payment = request.Payment,
                Penalties = request.Penalties,
                IsPaid = request.IsPaid,
            };

            _repository.Add(invoice);
            return await Task.FromResult(invoice);
        }
    }
}
