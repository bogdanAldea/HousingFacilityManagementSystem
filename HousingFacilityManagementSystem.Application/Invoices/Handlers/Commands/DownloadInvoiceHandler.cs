using HousingFacilityManagementSystem.Application.Invoices.Commands;
using HousingFacilityManagementSystem.Application.Options;
using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Patterns.FileWriter.Abstract;
using HousingFacilityManagementSystem.Core.Patterns.FileWriter.Concrete;
using HousingFacilityManagementSystem.Core.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Invoices.Handlers.Commands
{
    public class DownloadInvoiceHandler : IRequestHandler<DownloadInvoiceCommand, OperationResult<Invoice>>
    {

        private readonly IInvoiceRepository _repository;

        public DownloadInvoiceHandler(IInvoiceRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<Invoice>> Handle(DownloadInvoiceCommand request, CancellationToken cancellationToken)
        {
            OperationResult<Invoice> result = new OperationResult<Invoice>();
            Invoice invoice = await _repository.Get(request.Id);
            if (invoice == null)
            {
                result.IsError = true;
                result.ErrorCode = 404;
                result.Errors.Add("The invoice could not be found");
                return result;
            }

            if (request.Extension == "txt")
            {
                AbstractInvoiceFileWriter txtFileWriter = new TxtInvoiceFileWriter(data: invoice, extension: request.Extension.ToLower());
                txtFileWriter.WriteFile();
            }

            result.Payload = invoice;
            return result;
        }
    }
}
