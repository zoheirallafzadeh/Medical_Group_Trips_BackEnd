

using App.Domain.Core.Activity.Data.Repositories;

namespace App.Infra.Data.Repos.Ef.Activity
{
    public class FinalRegistrationCommandRepository : IFinalRegistrationCommandRepository
    {
        public Task Add(int ActivityId, int PersoneId, int ResponsibilityId, int PersonCreatorId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int FinalRegistrationId, int PersonDeletedId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
