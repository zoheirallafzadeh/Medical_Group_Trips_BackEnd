

using App.Domain.Core.Activity.Data.Repositories;
using App.Domain.Core.Activity.DTOs;
using App.Domain.Core.Activity.Services;

namespace App.Domain.Services.Activity
{

    public class ActivityService : IActivityService
    {
        private readonly IActivityCommandRepository _commandRepository;
        private readonly IActivityQueryRepository _queryRepository;
        public ActivityService(IActivityCommandRepository activityCommandRepository, IActivityQueryRepository activityQueryRepository)
        {
            _commandRepository = activityCommandRepository;
            _queryRepository = activityQueryRepository;
        }

        public async Task Add(DateOnly StartDate, DateOnly EndDate, CancellationToken cancellationToken, int? AreaId)
        {
            await _commandRepository.Add(StartDate, EndDate, cancellationToken, AreaId);
        }

        public async Task<ActivityDto> Get(int ActivityId, CancellationToken cancellationToken)
        {
            return await _queryRepository.Get(ActivityId, cancellationToken);
        }

        public async Task<List<ActivityDto>> Get(CancellationToken cancellationToken)
        {
            return await _queryRepository.Get(cancellationToken);
        }

        public async Task<List<ActivityDto>> Get(List<int> ActivityIds, CancellationToken cancellationToken)
        {
            return await _queryRepository.Get(ActivityIds, cancellationToken);
        }

        public async Task<List<ActivityDto>> GetLastAdd(int LastNumber, CancellationToken cancellationToken)
        {
            return await _queryRepository.GetLastAdd(LastNumber, cancellationToken);
        }

        public async Task<List<ActivityDto>> GetNotDone(CancellationToken cancellationToken)
        {
            return await _queryRepository.GetNotDone(cancellationToken);
        }

        public async Task Update(ActivityDto activityDto, CancellationToken cancellationToken)
        {
            await _commandRepository.Update(activityDto, cancellationToken);
        }
    }
}
