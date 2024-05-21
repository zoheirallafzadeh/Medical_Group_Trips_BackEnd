﻿using App.Domain.Core.Activity.DTOs;


namespace App.Domain.Core.Activity.AppServices
{
    public interface ActivityAppService
    {
        public Task Add (DateOnly StartDate , DateOnly EndDate ,CancellationToken cancellationToken ,int? AreaId );
        public Task<ActivityDto> Get(int ActivityId, CancellationToken cancellationToken);
        public Task<List<ActivityDto>> Get (CancellationToken cancellationToken);
        public Task<List<ActivityDto>> GetLastAdd(int LastNumber, CancellationToken cancellationToken);
        public Task<List<ActivityDto>> Get (List<int> ActivityIds, CancellationToken cancellationToken);

        public Task<List<ActivityDto>> GetNotDone(CancellationToken cancellationToken);

        public Task<ActivityDto> Update(CancellationToken cancellationToken);
    }
}
