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
    public class BranchedConsumableUtilitiesController : ControllerBase
    {

        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public BranchedConsumableUtilitiesController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;   
            _mapper = mapper;
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetBranchedUtilityById(int id)
        {
            var query = new GetBranchedUtilityByIdQuery { Id = id };
            var utility = await _mediator.Send(query);

            if (utility == null) { return NotFound(); }
            var mappedUtility = _mapper.Map<BranchedUtilityDto>(utility);
            return Ok(mappedUtility);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBranchedUtility(BranchedUtilityPostDto utilityDto)
        {
            var mappedUtility = _mapper.Map<BranchedUtilityPostDto, BranchedConsumableUtility>(utilityDto);
            var command = new CreateBranchedUtilityCommand { ApartmentId = mappedUtility.ApartmentId, Name = mappedUtility.Name };
            var createdUtility = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetBranchedUtilityById), new { Id = createdUtility.Id, Name = createdUtility.Name }, mappedUtility);
        }

        [HttpPut]
        [Route("{id}/current-month-index")]
        public async Task<IActionResult> UpdateCurrentMonthIndex(int id, BranchedUtilityPostDto utilityDto)
        {
            var mappedUtility = _mapper.Map<BranchedUtilityPostDto, BranchedConsumableUtility>(utilityDto);
            var command = new UpdateBranchedUtilityCurrentIndexCommand { Id = id, CurrentMonthIndex= mappedUtility.CurrentMonthIndex };
            await _mediator.Send(command);
            
            return NoContent();
        }

        [HttpPut]
        [Route("{id}/branched-status")]
        public async Task<IActionResult> SetBranchedStatus(int id, BranchedUtilityPostDto utilityDto)
        {
            var mappedUtility = _mapper.Map<BranchedUtilityPostDto, BranchedConsumableUtility>(utilityDto);
            var command = new SetBranchedStatusCommand { Id = id, IsBranched = mappedUtility.IsBranched };
            await _mediator.Send(command);

            return NoContent();
        }
    }
}