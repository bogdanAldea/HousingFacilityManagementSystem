using HousingFacilityManagementSystem.Application.Options;
using HousingFacilityManagementSystem.Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Invoices.Commands
{
    public class CreateInvoiceCommand : IRequest<OperationResult<Invoice>>
    {
        public decimal Payment { get; set; }
        public int ApartmentId { get; set; }
    }
}
