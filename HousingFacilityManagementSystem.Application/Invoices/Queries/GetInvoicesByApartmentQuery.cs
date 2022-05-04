﻿using HousingFacilityManagementSystem.Core.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingFacilityManagementSystem.Application.Invoices.Queries
{
    public class GetInvoicesByApartmentQuery : IRequest<List<Invoice>>
    {
        public int ApartmentId { get; set; }
    }
}
