using App.Domain.Core.Activity.DTOs;


namespace App.Domain.Core.Activity.Services
{
    public interface IActivityService
    {
        public Task Add(DateOnly StartDate, DateOnly EndDate, CancellationToken cancellationToken, int? AreaId);
        public Task<ActivityDto> Get(int ActivityId, CancellationToken cancellationToken);
        public Task<List<ActivityDto>> Get(CancellationToken cancellationToken);
        public Task<List<ActivityDto>> GetLastAdd(int LastNumber, CancellationToken cancellationToken);
        public Task<List<ActivityDto>> Get(List<int> ActivityIds, CancellationToken cancellationToken);
        public Task<List<ActivityDto>> GetNotDone(CancellationToken cancellationToken);
        public Task Update(ActivityDto activityDto , CancellationToken cancellationToken);
    }
}
