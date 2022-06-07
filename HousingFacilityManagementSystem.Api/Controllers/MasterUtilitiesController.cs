using AutoMapper;
using HousingFacilityManagementSystem.Api.DTOs;
using HousingFacilityManagementSystem.Api.DTOs.Utilities;
using HousingFacilityManagementSystem.Application.MasterUtils.Commands;
using HousingFacilityManagementSystem.Application.MasterUtils.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HousingFacilityManagementSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterUtilitiesController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public MasterUtilitiesController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;   
        }

        [Route("{id}")]
        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetMasterUtilityByIdQuery { Id = id };
            var result = await _mediator.Send(query);

            if (result.IsError) { return NotFound(result); }

            var mappedUtility = _mapper.Map<MasterUtilityDto>(result.Payload);
            return Ok(mappedUtility);
        }

        [Route("{id}/update")]
        [HttpPut]
        public async Task<IActionResult>Update(int id, MasterUtilityPostDto utilityDto)
        {
            var command = new UpdateMasterUtilityCommand
            {
                Id = id,
                Price = utilityDto.Price,
                CurrentMonthIndex = utilityDto.CurrentMonthIndex,
            };
            var result = await _mediator.Send(command);
            if (result.IsError) { return NotFound(result); }
            var responseDto = _mapper.Map<MasterUtilityDto>(result.Payload);
            return Ok(responseDto);
        }
    }
}
