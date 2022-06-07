using AutoMapper;
using HousingFacilityManagementSystem.Api.DTOs;
using HousingFacilityManagementSystem.Application.Buildings.Queries;
using HousingFacilityManagementSystem.Application.Apartments.Queries;
using HousingFacilityManagementSystem.Application.Buildings.Commands;
using HousingFacilityManagementSystem.Core.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HousingFacilityManagementSystem.Application.MasterUtils.Queries;

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
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetBuildingByIdQuery { Id = id };
            var building = await _mediator.Send(query);
            var mappedQuery = _mapper.Map<BuildingDto>(building.Payload);

            if (building.IsError) { return NotFound(building.Errors); }
            return Ok(mappedQuery);
        }

        [Route("{id}/apartments")]
        [HttpGet]
        public async Task<IActionResult> GetApartmentsByBuildingId(int id)
        {
            var query = new GetApartmentsByBuildingIdQuery { Id = id };
            var apartments = await _mediator.Send(query);
            var mappedQuery = _mapper.Map<List<ApartmentDto>>(apartments.Payload);

            return Ok(mappedQuery.ToList());
        }

        [Route("{id}/master-utils")]
        [HttpGet]
        public async Task<IActionResult> GetMasterUtilsByBuildingId(int id)
        {
            var query = new GetMasterUtilitiesByBuildingIdQuery { BuildingId = id };
            var result = await _mediator.Send(query);
            var mapperQuery = _mapper.Map<List<MasterUtilityDto>>(result.Payload);

            return Ok(mapperQuery.ToList());
        }


        [HttpPost]
        public async Task<IActionResult> CreateBuilding(BuildingPostDto buildingDto, CancellationToken cancellationToken)
        {
            var building = _mapper.Map<BuildingPostDto, Building>(buildingDto);
            var command = new CreateBuildingCommand
            {
                Capacity = building.Capacity,
                AdministratorId = building.AdministratorId,
                MasterConsumableUtilities = building.MasterConsumableUtilities.ToList(),
            };

            var created = await _mediator.Send(command, cancellationToken);
            return CreatedAtAction(nameof(GetById), new { Id = created.Payload.Id }, building);
            
        }

    }
}
