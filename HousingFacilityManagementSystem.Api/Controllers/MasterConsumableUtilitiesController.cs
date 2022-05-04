using AutoMapper;
using HousingFacilityManagementSystem.Api.DTOs;
using HousingFacilityManagementSystem.Application.Utilities.Commands;
using HousingFacilityManagementSystem.Application.Utilities.Queries;
using HousingFacilityManagementSystem.Core.Models;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HousingFacilityManagementSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterConsumableUtilitiesController : ControllerBase
    {

        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public MasterConsumableUtilitiesController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetMasterUtilityById(int id)
        {
            var query = new GetMasterUtilityByIdQuery() { Id = id };
            var utility = await _mediator.Send(query);

            if (utility == null) { return NotFound(); }
            var mappedUtility = _mapper.Map<MasterUtilityDto>(utility);
            return Ok(mappedUtility);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMasterUtility(MasterUtilityDto utilityDto)
        {
            //var command = new CreateMasterUtilityCommand() { BuildingId = buildingId, TotalIndex = totalIndex, Name = name };
            //var masterUtility = _mediator.Send(command);
            //var actionName = nameof(GetMasterUtilityById);
            //return CreatedAtAction(actionName, new { Id = masterUtility.Id }, masterUtility);

            var mappedUtility = _mapper.Map<MasterUtilityDto, MasterConsumableUtility>(utilityDto);
            var command = new CreateMasterUtilityCommand { 
                BuildingId = mappedUtility.BuildingId, 
                Name = mappedUtility.Name, 
                TotalIndex = mappedUtility.IndexMeter, 
                CurrentMonthIndex = mappedUtility.CurrentMonthIndex,
                Price = mappedUtility.Price 
            };

            var created = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetMasterUtilityById), new { Id = created.Id }, mappedUtility);

        }

        [Route("update-current-index/{id}")]
        [HttpPut]
        public async Task<IActionResult> UpdateMasterUtilityCurrentIndex(int id, MasterUtilityDto utilityDto)
        {
            //var updateCurrentMonthIndex = new UpdateMasterUtilityCurrentMonthIndexCommand() { Id = id, CurrentMonthIndex = currentMonthIndex };
            //var masterUtility = _mediator.Send(updateCurrentMonthIndex);
            //return Ok(masterUtility);

            var mappedUtility = _mapper.Map<MasterUtilityDto, MasterConsumableUtility>(utilityDto);
            var command = new UpdateMasterUtilityCurrentMonthIndexCommand { Id = id, CurrentMonthIndex = mappedUtility.CurrentMonthIndex};
            await _mediator.Send(command);
            return NoContent();
        }

        [Route("update-price/{id}")]
        [HttpPut]
        public async Task<IActionResult> UpdateMasterUtilityPrice(int id, MasterUtilityDto utilityDto)
        {
            //var updatePriceCommand = new UpdateMasterUtilityPriceCommand() { Id=id, Price = price };
            //var masterUtility = _mediator.Send(updatePriceCommand);
            //return Ok(masterUtility);

            var mappedUtility = _mapper.Map<MasterUtilityDto, MasterConsumableUtility>(utilityDto);
            var command = new UpdateMasterUtilityPriceCommand { Id = id, Price = mappedUtility.Price };
            await _mediator.Send(command);
            return NoContent();
        }
    }
}