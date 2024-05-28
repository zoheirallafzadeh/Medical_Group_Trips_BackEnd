using App.Domain.Core.Activity.AppServices;
using App.Domain.Core.Activity.DTOs;
using App.EndPoint.ClientAPI.Areas.Admin.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace App.EndPoint.ClientAPI.Areas.Member.Controllers.Activity
{

    [Area("member")]
    [Route("api/[Area]/[controller]/")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private readonly IActivityAppService _activityAppService;
        public ActivityController(IActivityAppService activityAppService)
        {
            _activityAppService = activityAppService;
        }


        [HttpGet]
        public async Task<List<ActivityDto>> Get(CancellationToken cancellationToken)
        {
            return await _activityAppService.Get(cancellationToken);
        }
        [HttpGet("{ActivityId}")]
        public async Task<ActivityDto> Get(int ActivityId, CancellationToken cancellationToken)
        {
            return await _activityAppService.Get(ActivityId, cancellationToken);
        }

        [HttpGet]
        [Route("[Action]")]
        public async Task<List<ActivityDto>> GetLastAdd(int LastNumber, CancellationToken cancellationToken)
        {
            return await _activityAppService.GetLastAdd(LastNumber, cancellationToken);
        }


        [HttpGet]
        [Route("[Action]")]
        public async Task<List<ActivityDto>> GetNotDone(CancellationToken cancellationToken)
        {
            return await _activityAppService.GetNotDone(cancellationToken);
        }


        [HttpPost]
        [Route("[Action]")]
        public async Task<List<ActivityDto>> GetBuyActivitysId([FromBody] List<int> ActivityIds, CancellationToken cancellationToken)
        {
            return await _activityAppService.Get(ActivityIds, cancellationToken);
        }


    }
}
