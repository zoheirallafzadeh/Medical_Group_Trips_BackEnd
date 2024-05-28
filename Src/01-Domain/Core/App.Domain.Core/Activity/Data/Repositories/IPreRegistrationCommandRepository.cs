

using App.Domain.Core.Activity.DTOs;

namespace App.Domain.Core.Activity.Data.Repositories
{
    public interface IPreRegistrationCommandRepository
    {
        public Task Add(int ActivityId, int PersoneId, int ResponsibilityId, int PersonCreatorId, CancellationToken cancellationToken);
        public Task Delete(int PreRegisterationId, int PersonDeletedId, CancellationToken cancellationToken);
    }
}
