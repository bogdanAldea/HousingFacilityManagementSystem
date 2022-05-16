using AutoMapper;
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

        [HttpGet]
        [Route("admins/{id}")]
        public async Task<IActionResult> GetAdminById(int id)
        {
            var query = new GetAdministratorByIdQuery { Id = id };
            var adminProfile = await _mediator.Send(query);

            if (adminProfile == null) { return NotFound(); }

            var mappedAdmin = _mapper.Map<AdministratorProfile>(adminProfile);
            return Ok(mappedAdmin);
        }

        [HttpGet]
        [Route("tenants/{id}")]
        public async Task<IActionResult> GetTenantById(int id)
        {
            return Ok();
        }
    }
}
