

using App.Domain.Core.Activity.Data.Repositories;

namespace App.Infra.Data.Repos.Ef.Activity
{
    internal class PreRegistrationCommandRepository : IPreRegistrationCommandRepository
    {
        public Task Add(int ActivityId, int PersoneId, int ResponsibilityId, int PersonCreatorId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int PreRegisterationId, int PersonDeletedId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
