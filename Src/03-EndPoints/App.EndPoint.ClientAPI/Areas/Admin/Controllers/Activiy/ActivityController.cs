using App.Domain.Core.Activity.AppServices;
using App.Domain.Core.Activity.DTOs;
using App.EndPoint.ClientAPI.Areas.Admin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoint.ClientAPI.Areas.Admin.Controllers.Activiy
{

    [Area("admin")]
    [Route("api/[Area]/[controller]/")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IActivityAppService _activityAppService;
        public ActivityController(IActivityAppService activityAppService)
        {
            _activityAppService = activityAppService;
        }


        [Route("[Action]")]
        [HttpPost]
        public async Task<IActionResult> Add(ActivityAddModel activityAddModel, CancellationToken cancellationToken)
        {
            
            await _activityAppService.Add(activityAddModel.StartDate, activityAddModel.EndDate, cancellationToken, activityAddModel.AreaId);
            return Ok();
        }


        [HttpPost]
        [Route("[Action]")]
        public async Task Update(ActivityDto activityDto, CancellationToken cancellationToken)
        {
            await _activityAppService.Update(activityDto, cancellationToken);
        }

    }
}
