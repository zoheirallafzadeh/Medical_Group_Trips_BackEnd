using App.Domain.Core.Activity.DTOs.Activity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Activity.AppServices
{
    public interface ActivityAppService
    {
        public Task Add (DateOnly StartDate , DateOnly EndDate ,CancellationToken cancellationToken ,int? AreaId );
        public Task<ActivityDto> Get(int ActivityId, CancellationToken cancellationToken);
        public Task<List<ActivityLeastDto>> Get (CancellationToken cancellationToken);
        public Task<List<ActivityLeastDto>> GetLastAdd(int LastNumber, CancellationToken cancellationToken);
        public Task<List<ActivityLeastDto>> Get (List<int> ActivityIds, CancellationToken cancellationToken);

        public Task<List<ActivityLeastDto>> GetNotDone(CancellationToken cancellationToken);

        public Task<ActivityDto> Update(CancellationToken cancellationToken);




    }
}
