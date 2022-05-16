using AutoMapper;
using HousingFacilityManagementSystem.Api.DTOs;
using HousingFacilityManagementSystem.Application.Invoices.Commands;
using HousingFacilityManagementSystem.Application.Invoices.Queries;
using HousingFacilityManagementSystem.Core.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HousingFacilityManagementSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicesController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public InvoicesController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;   
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetInvoiceById(int id)
        {
            var query = new GetInvoiceByIdQuery { Id = id };
            var invoice = await _mediator.Send(query);

            if (invoice == null) { return NotFound(); }
            var mappedInvoice = _mapper.Map<Invoice>(invoice);
            return Ok(mappedInvoice);
        }

        [HttpGet]
        public async Task<IActionResult> GetInvoicesByApartment(int apartmentId)
        {
            var query = new GetInvoicesByApartmentQuery { ApartmentId = apartmentId };
            var invoices = await _mediator.Send(query);

            var mappedInvoiceList = _mapper.Map<List<Invoice>>(invoices);
            return Ok(mappedInvoiceList);
        }

        [HttpPost]
        public async Task<IActionResult> CreateInvoice(InvoiceDto invoiceDto)
        {
            var mapperInvoice = _mapper.Map<InvoiceDto, Invoice>(invoiceDto);
            var command = new CreateInvoiceCommand
            {
                ApartmentId = invoiceDto.ApartmentId,
                Number = invoiceDto.Number,
                IsPaid = invoiceDto.IsPaid,
                Payment = invoiceDto.Payment,
                Penalties = invoiceDto.Penalties
            };
            var createdInvoice = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetInvoiceById), new { Id=createdInvoice.Id }, mapperInvoice);
        }
    }
}