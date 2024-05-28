
using App.Domain.Core.Activity.Entities;
using App.Domain.Core.Activity.Data.Repositories;
using App.Domain.Core.Activity.DTOs;

namespace App.Infra.Data.Repos.Ef.Activity
{
    public class ActivityQueryRepository : IActivityQueryRepository
    {
        public Task<ActivityDto> Get(int ActivityId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            
        }

        public Task<List<ActivityDto>> Get(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<ActivityDto>> Get(List<int> ActivityIds, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<ActivityDto>> GetLastAdd(int LastNumber, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<ActivityDto>> GetNotDone(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
