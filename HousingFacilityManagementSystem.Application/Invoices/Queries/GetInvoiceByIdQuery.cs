using HousingFacilityManagementSystem.Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Invoices.Queries
{
    public class GetInvoiceByIdQuery : IRequest<Invoice>
    {
        public int Id { get; set; }
    }
}
