using AutoMapper;
using HousingFacilityManagementSystem.Api.DTOs;
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
        private readonly IMapper _mapper;

        public BuildingsController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [Route("{id}")]
        [HttpGet]
        public async Task<IActionResult> GetBuildingById(int id)
        {
            var query = new GetBuildingByIdQuery { Id = id };
            var building = await _mediator.Send(query);

            if (building == null) { return NotFound(); }
            var mappedBuilding = _mapper.Map <BuildingDto>(building);
            return Ok(mappedBuilding);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBuilding(BuildingPostDto newBuilding)
        {
            var building = _mapper.Map <BuildingPostDto, Building>(newBuilding);
            var command = new CreateBuildingCommand { Capacity = building.Capacity };
            var createdBuilding = await _mediator.Send(command);
            
            return CreatedAtAction(nameof(GetBuildingById), new { Id = createdBuilding.Id }, createdBuilding);
        }
    }
}
