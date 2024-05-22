using App.Domain.Core.Activity.AppServices;
using App.Domain.Core.Activity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Activity
{
    public class ActivityAppService : IActivityAppService
    {
        public Task Add(DateOnly StartDate, DateOnly EndDate, CancellationToken cancellationToken, int? AreaId)
        {
            throw new NotImplementedException();
        }

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

        public Task<ActivityDto> Update(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
