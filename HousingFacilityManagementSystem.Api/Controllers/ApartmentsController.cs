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

        public ApartmentsController(IMediator mediator)
        {
            _mediator = mediator;   
        }

        [HttpGet]
        public async Task<IActionResult> GetApartmentById(int id)
        {
            var command = new GetApartmentByIdQuery(id);
            var apartment = _mediator.Send(command);
            return Ok(apartment);
        }

    }
}
