using AutoMapper;
using HousingFacilityManagementSystem.Api.DTOs;
using HousingFacilityManagementSystem.Api.DTOs.Utilities;
using HousingFacilityManagementSystem.Application.BranchedUtils.Commands;
using HousingFacilityManagementSystem.Application.BranchedUtils.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HousingFacilityManagementSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchedUtilitiesController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public BranchedUtilitiesController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [Route("{id}")]
        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetBranchedUtilityById { Id = id };
            var result = await _mediator.Send(query);

            if (result.IsError) { return NotFound(result); }
            var mapped = _mapper.Map<BranchedUtilityDto>(result.Payload);
            return Ok(mapped);
        }

        [Route("{id}/update")]
        [HttpPut]
        public async Task<IActionResult> Update(int id, MasterToBranchedDto utilityDto)
        {
            var command = new UpdateBranchedUtilityCommand
            {
                Id = id,
                CurrentMonthIndex = utilityDto.CurrentMonthIndex,
                IsBranched = utilityDto.IsBranched,
                MasterConsumableUtilityId = utilityDto.MasterConsumableUtilityId,
            };
 
            var result = await _mediator.Send(command);

            if (result.IsError) { return NotFound(result.Errors); }
            var responseDto = _mapper.Map<BranchedUtilityDto>(result.Payload);
            return Ok(responseDto);
        }

    }
}
