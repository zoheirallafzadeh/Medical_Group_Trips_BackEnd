using App.Domain.Core.Activity.AppServices;
using App.Domain.Core.Activity.DTOs;
using App.EndPoint.ClientAPI.Areas.Admin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoint.ClientAPI.Areas.Admin.Controllers
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
        public async void Add(ActivityAddModel activityAddModel, CancellationToken cancellationToken)
        {


            await _activityAppService.Add(activityAddModel.StartDate, activityAddModel.EndDate, cancellationToken, activityAddModel.AreaId);
        }

        [HttpGet]
        [Route("[Action]")]
        public IActionResult Get() {
            return Ok(DateOnly.FromDateTime(DateTime.Now));
            
        }
    }
}
