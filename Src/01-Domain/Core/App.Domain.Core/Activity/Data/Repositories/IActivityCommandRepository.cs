
using App.Domain.Core.Activity.DTOs;

namespace App.Domain.Core.Activity.Data.Repositories
{
    public interface IActivityCommandRepository
    {
        public Task Add(DateOnly StartDate, DateOnly EndDate, CancellationToken cancellationToken, int? AreaId);
        public Task Update(ActivityDto activityDto,CancellationToken cancellationToken);
    }
}
