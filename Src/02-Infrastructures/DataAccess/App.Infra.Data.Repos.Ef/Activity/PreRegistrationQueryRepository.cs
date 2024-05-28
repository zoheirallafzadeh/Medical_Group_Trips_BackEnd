

using App.Domain.Core.Activity.Data.Repositories;
using App.Domain.Core.Activity.DTOs;

namespace App.Infra.Data.Repos.Ef.Activity
{
    public class PreRegistrationQueryRepository : IPreRegistrationQueryRepository
    {
        public Task<List<PreRegistrationDto>> Get(int ActivityId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
