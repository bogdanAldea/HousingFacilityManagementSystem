using HousingFacilityManagementSystem.Application.Utilities.Commands;
using HousingFacilityManagementSystem.Application.Utilities.Queries;
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

        public MasterConsumableUtilitiesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetMasterUtilityById(int id)
        {
            var getMasterUtilityQuery = new GetMasterUtilityByIdQuery() { Id = id };
            var utility = _mediator.Send(getMasterUtilityQuery);
            return Ok(utility);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMasterUtility(int buildingId, int totalIndex, string name)
        {
            var createMasterUtilityCommand = new CreateMasterUtilityCommand() { BuildingId = buildingId, TotalIndex = totalIndex, Name = name };
            var masterUtility = _mediator.Send(createMasterUtilityCommand);
            var actionName = nameof(GetMasterUtilityById);
            return CreatedAtAction(actionName, new { Id = masterUtility.Id }, masterUtility);
        }

        [Route("update-current-index/{id}")]
        [HttpPut]
        public async Task<IActionResult> UpdateMasterUtilityCurrentIndex(int id, int currentMonthIndex)
        {
            var updateCurrentMonthIndex = new UpdateMasterUtilityCurrentMonthIndexCommand() { Id = id, CurrentMonthIndex = currentMonthIndex };
            var masterUtility = _mediator.Send(updateCurrentMonthIndex);
            return Ok(masterUtility);
        }

        [Route("update-price/{id}")]
        [HttpPut]
        public async Task<IActionResult> UpdateMasterUtilityPrice(int id, decimal price)
        {
            var updatePriceCommand = new UpdateMasterUtilityPriceCommand() { Id=id, Price = price };
            var masterUtility = _mediator.Send(updatePriceCommand);
            return Ok(masterUtility);
        }
    }
}
