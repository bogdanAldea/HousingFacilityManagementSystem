using AutoMapper;
using HousingFacilityManagementSystem.Api.DTOs;
using HousingFacilityManagementSystem.Application.Buildings.Queries;
using HousingFacilityManagementSystem.Application.UserProfiles.Queries;
using HousingFacilityManagementSystem.Core.Models.Users;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HousingFacilityManagementSystem.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfilesController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public UserProfilesController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [Route("admins/{id}")]
        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetUserProfileById { Id = id };
            var result = await _mediator.Send(query);

            if (result.IsError) { return NotFound(result); }

            var profile = _mapper.Map<AdministratorProfileDto>(result.Payload);
            return Ok(profile);
        }

        [Route("admins/{id}/building")]
        [HttpGet]
        public async Task<IActionResult> GetBuildingByAdmin(int id)
        {
            var query = new GetBuildingByAdminIdQuery { AdministratorId = id };
            var result = await _mediator.Send(query);
            if (result.IsError) { return NotFound(result); }
            var building = _mapper.Map<BuildingDto>(result.Payload);
            return Ok(building);
        }
    }
}
