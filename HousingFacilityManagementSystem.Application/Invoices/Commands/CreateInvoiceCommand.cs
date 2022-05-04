using HousingFacilityManagementSystem.Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Invoices.Commands
{
    public class CreateInvoiceCommand : IRequest<Invoice>
    {
        public int ApartmentId { get; set; }
        public int Number { get; set; }
        public decimal Payment { get; set; }
        public decimal Penalties { get; set; }
        public bool IsPaid { get; set; }
    }
}
