using HousingFacilityManagementSystem.Application.Invoices.Queries;
using HousingFacilityManagementSystem.Application.Options;
using HousingFacilityManagementSystem.Core.Models;
using HousingFacilityManagementSystem.Core.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Invoices.Handlers.Queries
{
    public class GetInvoicesByApartmentIdHandler : IRequestHandler<GetInvoicesByApartmentIdQuery, OperationResult<List<Invoice>>>
    {

        private readonly IInvoiceRepository _repository;

        public GetInvoicesByApartmentIdHandler(IInvoiceRepository repository)
        {
            _repository = repository;
        }

        public async Task<OperationResult<List<Invoice>>> Handle(GetInvoicesByApartmentIdQuery request, CancellationToken cancellationToken)
        {
            OperationResult<List<Invoice>> result = new OperationResult<List<Invoice>>();

            var querySet = await _repository.GetAllByApartment(request.ApartmentId);
            result.Payload = querySet.ToList();
            return result;

        }
    }
}
