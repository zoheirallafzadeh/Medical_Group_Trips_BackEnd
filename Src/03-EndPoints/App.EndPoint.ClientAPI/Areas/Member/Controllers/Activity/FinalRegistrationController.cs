using App.Domain.Core.Activity.AppServices;
using App.Domain.Core.Activity.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoint.ClientAPI.Areas.Member.Controllers.Activity
{
    [Area("mamber")]
    [Route("api/[Area]/[controller]/")]
    [ApiController]
    public class FinalRegistrationController : ControllerBase
    {
        private readonly IFinalRegistrationAppService _finalRegistrationAppService;
        public FinalRegistrationController(IFinalRegistrationAppService finalRegistrationAppService)
        {
            _finalRegistrationAppService = finalRegistrationAppService;
        }

        [HttpGet("{ActivityId}")]
        public async Task<IEnumerable<FinalRegistrationDto>> Get(int ActivityId , CancellationToken cancellationToken)
        {
            return await _finalRegistrationAppService.Get(ActivityId, cancellationToken);
        }

    }
}
