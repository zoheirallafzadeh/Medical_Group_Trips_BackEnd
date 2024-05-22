

using App.Domain.Core.Activity.DTOs;

namespace App.Domain.Core.Activity.Data.Repositories
{
    public interface IActivityQueryRepository
    {
        public Task<ActivityDto> Get(int ActivityId, CancellationToken cancellationToken);
        public Task<List<ActivityDto>> Get(CancellationToken cancellationToken);
        public Task<List<ActivityDto>> GetLastAdd(int LastNumber, CancellationToken cancellationToken);
        public Task<List<ActivityDto>> Get(List<int> ActivityIds, CancellationToken cancellationToken);
        public Task<List<ActivityDto>> GetNotDone(CancellationToken cancellationToken);
    }
}
