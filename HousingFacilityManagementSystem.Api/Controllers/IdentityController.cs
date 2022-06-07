using AutoMapper;
using HousingFacilityManagementSystem.Api.DTOs;
using HousingFacilityManagementSystem.Application.Identity.Commands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HousingFacilityManagementSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {

        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public IdentityController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [Route("register/admin")]
        [HttpPost]
        public async Task<IActionResult> Register(UserRegistrationDto registrationDto)
        {
            var command = _mapper.Map<RegisterAdminCommand>(registrationDto);
            var result = await _mediator.Send(command);

            if (result.ErrorCode == 404) { return NotFound(result.Errors); }
            else if (result.ErrorCode == 400) { return BadRequest(result.Errors); }

            return Ok(result.Payload);
        }

        [Route("login/admin")]
        [HttpPost]
        public async Task<IActionResult> Login(UserLoginDto loginDto)
        {
            var command = _mapper.Map<LoginAdminCommand>(loginDto);
            var result = await _mediator.Send(command);

            if (result.IsError)
            {
                if (result.ErrorCode == 404) { return NotFound(result.Errors); }
                if (result.ErrorCode == 400) { return BadRequest(result.Errors); }
            }

            return Ok(result.Payload);
        }
    }
}
