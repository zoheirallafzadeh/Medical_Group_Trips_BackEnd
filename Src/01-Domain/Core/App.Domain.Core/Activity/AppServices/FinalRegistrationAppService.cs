using App.Domain.Core.Activity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Activity.AppServices
{
    public interface FinalRegistrationAppService
    {
        public Task Add(int ActivityId, int PersoneId, int ResponsibilityId, int PersonCreatorId, CancellationToken cancellationToken);
        public Task<List<FinalRegistrationDto>> Get(int ActivityId, CancellationToken cancellationToken);

        public Task Delete(int FinalRegistrationId, int PersonDeletedId, CancellationToken cancellationToken);

    }
}
