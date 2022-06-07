using AutoMapper;
using HousingFacilityManagementSystem.Api.DTOs;
using HousingFacilityManagementSystem.Api.DTOs.Invoices;
using HousingFacilityManagementSystem.Application.Apartments.Commands;
using HousingFacilityManagementSystem.Application.Apartments.Queries;
using HousingFacilityManagementSystem.Application.Invoices.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace HousingFacilityManagementSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApartmentsController : ControllerBase
    {

        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public ApartmentsController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [Route("{id}")]
        [HttpGet]
        public async Task<IActionResult> GetApartmentById(int id)
        {
            var query = new GetApartmentByIdQuery { Id = id };
            var apartment = await _mediator.Send(query);
            var mappedQuery = _mapper.Map<ApartmentDto>(apartment.Payload);

            if (apartment.IsError) { return NotFound(apartment.Errors); }
            return Ok(mappedQuery);
        }

        [Route("{id}/invoices")]
        [HttpGet]
        public async Task<IActionResult> GetInvoicesByApartmentId(int id)
        {
            var query = new GetInvoicesByApartmentIdQuery { ApartmentId = id };
            var result = await _mediator.Send(query);

            if (result.IsError) { return BadRequest(result); }

            var mappedQuery = _mapper.Map<List<InvoiceDto>>(result.Payload);
            return Ok(mappedQuery);
        }


        [Route("{id}")]
        [HttpPut]
        public async Task<IActionResult> UpdateApartment(int id, ApartmentPutDto apartment)
        {
            var command = new UpdateApartmentCommand { Id = id, Residents = apartment.Residents, SurfaceArea = apartment.SurfaceArea };
            var result = await _mediator.Send(command); 

            if (result.IsError) { return NotFound(result.Errors); }
            return Ok(result.Payload);
        }
    }
}
