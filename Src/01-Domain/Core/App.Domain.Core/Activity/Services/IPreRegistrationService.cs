using App.Domain.Core.Activity.DTOs;

namespace App.Domain.Core.Activity.Services
{
    public interface IPreRegistrationService
    {
        public Task Add(int ActivityId, int PersoneId, int ResponsibilityId, int PersonCreatorId, CancellationToken cancellationToken);
        public Task<List<PreRegistrationDto>> Get(int ActivityId, CancellationToken cancellationToken);
        public Task Delete(int PreRegisterationId, int PersonDeletedId, CancellationToken cancellationToken);
    }
}
