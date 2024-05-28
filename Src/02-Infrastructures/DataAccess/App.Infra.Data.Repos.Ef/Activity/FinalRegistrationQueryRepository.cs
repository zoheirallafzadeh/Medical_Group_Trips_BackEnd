

using App.Domain.Core.Activity.Data.Repositories;
using App.Domain.Core.Activity.DTOs;


namespace App.Infra.Data.Repos.Ef.Activity
{
    public class FinalRegistrationQueryRepository : IFinalRegistrationQueryRepository
    {
        public Task<List<FinalRegistrationDto>> Get(int ActivityId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            
        }
    }
}
