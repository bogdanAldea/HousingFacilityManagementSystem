using HousingFacilityManagementSystem.Application.Buildings.Commands;
using HousingFacilityManagementSystem.Application.Buildings.Queries;
using HousingFacilityManagementSystem.Core.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HousingFacilityManagementSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingsController : ControllerBase
    {

        private readonly IMediator _mediator;

        public BuildingsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetBuildingById(int id)
        {
            var command = new GetBuildingByIdQuery(id);
            var building = _mediator.Send(command);
            return Ok(building);    
        }

        [HttpPost]
        public async Task<IActionResult> CreateBuilding(int capacity)
        {
            var command = new CreateBuildingCommand(capacity);
            var building = _mediator.Send(command);
            return Ok(building);
        }
    }
}
