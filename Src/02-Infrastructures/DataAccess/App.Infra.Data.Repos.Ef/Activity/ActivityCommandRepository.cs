using App.Domain.Core.Activity.Data.Repositories;
using App.Domain.Core.Activity.DTOs;

namespace App.Infra.Data.Repos.Ef.Activity
{
    public class ActivityCommandRepository : IActivityCommandRepository
    {
        public Task Add(DateOnly StartDate, DateOnly EndDate, CancellationToken cancellationToken, int? AreaId)
        {
            throw new NotImplementedException();
        }

        public Task Update(ActivityDto activityDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
