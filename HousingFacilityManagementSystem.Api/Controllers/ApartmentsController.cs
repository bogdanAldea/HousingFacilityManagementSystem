using AutoMapper;
using HousingFacilityManagementSystem.Api.DTOs;
using HousingFacilityManagementSystem.Application.Apartments.Commands;
using HousingFacilityManagementSystem.Application.Apartments.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
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

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetApartmentById(int id)
        {
            var query = new GetApartmentByIdQuery(id);
            var apartment = await _mediator.Send(query);

            if (apartment == null) { return NotFound(); }
            var mappedApartment = _mapper.Map<ApartmentDto>(apartment);
            return Ok(mappedApartment);
        }

        [HttpPut]
        [Route("{id}/residents")]
        public async Task<IActionResult> UpdateResidents(int id, ApartmentDto updatedApartment)
        {
            var command = new UpdateResidentsCommand { Id = id, Residents = updatedApartment.Residents };
            var apartment = await _mediator.Send(command);

            return NoContent();
        }

        [HttpPut]
        [Route("{id}/surface-area")]
        public async Task<IActionResult> UpdateSurfaceArea(int id, ApartmentDto updatedApartment)
        {
            var command = new UpdateSurfaceAreaCommand { Id = id, SurfaceArea = updatedApartment.SurfaceArea };
            var apartment = await _mediator.Send(command);

            if (apartment != null) { return NotFound(); }
            return NoContent();
        }
    }
}
