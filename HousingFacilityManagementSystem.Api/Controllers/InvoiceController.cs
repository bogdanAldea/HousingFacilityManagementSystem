using AutoMapper;
using HousingFacilityManagementSystem.Api.DTOs.Invoices;
using HousingFacilityManagementSystem.Application.Invoices.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HousingFacilityManagementSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoiceController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public InvoiceController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [Route("{id}")]
        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok();
        }

        [Route("download")]
        [HttpPost]
        public async Task<IActionResult> DownloadInvoice(InvoiceDownloadDto invoiceDownloadDto)
        {
            var command = new DownloadInvoiceCommand()
            {
                Id = invoiceDownloadDto.Id,
                Extension = invoiceDownloadDto.Extension,
            };

            var result = await _mediator.Send(command);
            if (result.IsError) { return NotFound(result); }

            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> PostInvoice(InvoicePostDto invoiceDto)
        {
            var command = new CreateInvoiceCommand()
            {
                ApartmentId = invoiceDto.ApartmentId,
                Payment = invoiceDto.Payment,
            };

            var result = await _mediator.Send(command);
            var mappedInvoice = _mapper.Map<InvoiceDto>(result.Payload);

            return Ok(mappedInvoice);
        }
    }
}
