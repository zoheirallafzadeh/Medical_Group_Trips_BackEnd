using App.Domain.Core.Activity.AppServices;
using App.Domain.Core.Activity.DTOs;
using App.EndPoint.ClientAPI.Areas.Member.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoint.ClientAPI.Areas.Member.Controllers.Activity
{
    [Area("mamber")]
    [Route("api/[Area]/[controller]/")]
    [ApiController]
    public class PreRegistrationController : ControllerBase
    {
        private readonly IPreRegistrationAppService _preRegistrationAppService;
        public PreRegistrationController(IPreRegistrationAppService preRegistrationAppService)
        {
            _preRegistrationAppService = preRegistrationAppService;
        }

        [Route("[Action]")]
        [HttpPost]

        public async Task<IActionResult> Add([FromBody] PreRegistrationAddModel preRegistrationAddModel, CancellationToken cancellationToken)
        {
            int PersonCreatorId = 0;
            await _preRegistrationAppService.Add(preRegistrationAddModel.ActivityId, preRegistrationAddModel.PersoneId, preRegistrationAddModel.ResponsibilityId, PersonCreatorId, cancellationToken);

            return Ok();

        }

        [HttpGet("{ActivityId}")]
        public async Task<List<PreRegistrationDto>> Get(int ActivityId, CancellationToken cancellationToken)
        {
            return await _preRegistrationAppService.Get(ActivityId, cancellationToken);
        }

        [HttpDelete("{PersonDeletedId}")]
        public async Task Delete(int PreRegisterationId, CancellationToken cancellationToken)
        {
            int PersonDeletedId = 0;
            await _preRegistrationAppService.Delete(PreRegisterationId, PersonDeletedId, cancellationToken);
            
        }

    }
}
