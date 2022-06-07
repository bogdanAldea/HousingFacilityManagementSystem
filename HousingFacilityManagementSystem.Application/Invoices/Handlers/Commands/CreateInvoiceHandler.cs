using HousingFacilityManagementSystem.Application.Invoices.Commands;
using HousingFacilityManagementSystem.Application.Options;
using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Invoices.Handlers.Commands
{
    public class CreateInvoiceHandler : IRequestHandler<CreateInvoiceCommand, OperationResult<Invoice>>
    {

        private readonly IInvoiceRepository _repository;

        public CreateInvoiceHandler(IInvoiceRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<Invoice>> Handle(CreateInvoiceCommand request, CancellationToken cancellationToken)
        {
            OperationResult<Invoice> result = new OperationResult<Invoice>();
            Invoice newInvoice = new Invoice(payment: request.Payment, apartmentId: request.ApartmentId);

            await _repository.Post(newInvoice);
            result.Payload = newInvoice;
            return result;

        }
    }
}
