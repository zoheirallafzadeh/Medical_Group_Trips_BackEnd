using App.Domain.Core.Activity.AppServices;
using App.EndPoint.ClientAPI.Areas.Admin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoint.ClientAPI.Areas.Admin.Controllers.Activiy
{
    [Area("admin")]
    [Route("api/[Area]/[controller]/")]
    [ApiController]
    public class FinalRegistrationController : ControllerBase
    {
        private readonly IFinalRegistrationAppService _finalRegistrationAppService;
        public FinalRegistrationController(IFinalRegistrationAppService finalRegistrationAppService)
        {
            _finalRegistrationAppService = finalRegistrationAppService;
        }

        [Route("[Action]")]
        [HttpPost]
        public async Task Add(FinalRegistrationModel finalRegistrationModel , CancellationToken cancellationToken)
        {
            await _finalRegistrationAppService.Add(finalRegistrationModel.ActivityId, finalRegistrationModel.PersonId,finalRegistrationModel.ResponsibilityId, finalRegistrationModel.PersonCreatorId, cancellationToken);
        }

        //[HttpDelete("{FinalRegistrationId}")]
        //[Route("[Action]")]
        //public async Task Delete(int FinalRegistrationId , CancellationToken cancellationToken)
        //{
        //    int PersonDeletedId = User.Identity
        //    await _finalRegistrationAppService.Delete(FinalRegistrationId, 23, cancellationToken);
        //}

    }
}
