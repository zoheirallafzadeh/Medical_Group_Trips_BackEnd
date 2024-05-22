using App.Domain.Core.Activity.AppServices;
using App.Domain.Core.Activity.DTOs;
using App.Domain.Core.Activity.Services;


namespace App.Domain.AppServices.Activity
{
    public class ActivityAppService : IActivityAppService
    {
        private readonly IActivityService _activityService;
        public ActivityAppService(IActivityService activityService) => _activityService = activityService;

        public async Task Add(DateOnly StartDate, DateOnly EndDate, CancellationToken cancellationToken, int? AreaId)
        {
            await _activityService.Add(StartDate, EndDate, cancellationToken, AreaId);
        }

        public async Task<ActivityDto> Get(int ActivityId, CancellationToken cancellationToken)
        {
            return await _activityService.Get(ActivityId, cancellationToken);
        }

        public async Task<List<ActivityDto>> Get(CancellationToken cancellationToken)
        {
            return await _activityService.Get(cancellationToken);
        }

        public async Task<List<ActivityDto>> Get(List<int> ActivityIds, CancellationToken cancellationToken)
        {
            return await _activityService.Get(ActivityIds, cancellationToken);
        }

        public async Task<List<ActivityDto>> GetLastAdd(int LastNumber, CancellationToken cancellationToken)
        {
            return await _activityService.GetLastAdd(LastNumber, cancellationToken);
        }

        public async Task<List<ActivityDto>> GetNotDone(CancellationToken cancellationToken)
        {
            return await _activityService.GetNotDone(cancellationToken);
        }

        public async Task Update(ActivityDto activityDto, CancellationToken cancellationToken)
        {
            await _activityService.Update(activityDto, cancellationToken);
        }
    }
}
