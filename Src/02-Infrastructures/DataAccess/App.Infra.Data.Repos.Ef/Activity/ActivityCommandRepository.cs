using App.Domain.Core.Activity.Entities;
using App.Domain.Core.Activity.Data.Repositories;
using App.Domain.Core.Activity.DTOs;
using App.Infa.Data.Db.SqlServer.Ef.DbCtx;
using Microsoft.EntityFrameworkCore;

namespace App.Infra.Data.Repos.Ef.Activity
{
    public class ActivityCommandRepository : IActivityCommandRepository
    {
        private readonly AppDbContext _appDbContext;

        public ActivityCommandRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task Add(DateOnly startDate, DateOnly endDate, CancellationToken cancellationToken, int? areaId)
        {

            App.Domain.Core.Activity.Entities.Activity newActivity = new()
            {
                StartDate = startDate,
                EndDate = endDate,

            };
            if (areaId != null)
            {
                newActivity.AreaId = (int)areaId;

            }

            await _appDbContext.Activities.AddAsync(newActivity);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task Update(ActivityDto activityDto, CancellationToken cancellationToken)
        {
            var oldActivity = await _appDbContext.Activities.FirstOrDefaultAsync(u => u.Id == activityDto.Id);
            if (oldActivity != null)
            {
                oldActivity.StartDate = activityDto.StartDate;
                oldActivity.EndDate = activityDto.EndDate;
                if (activityDto.AreaId != null)
                {
                    oldActivity.AreaId = (int)activityDto.AreaId;
                }
                if (activityDto.IsDone != null)
                {
                    oldActivity.IsDone = oldActivity.IsDone;
                }
                await _appDbContext.SaveChangesAsync(cancellationToken);
            }
        }

    }
}
