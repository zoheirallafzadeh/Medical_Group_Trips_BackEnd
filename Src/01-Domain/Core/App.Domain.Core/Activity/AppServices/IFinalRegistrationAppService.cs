using App.Domain.Core.Activity.DTOs;


namespace App.Domain.Core.Activity.AppServices
{
    public interface IFinalRegistrationAppService
    {
        public Task Add(int ActivityId, int PersoneId, int ResponsibilityId, int PersonCreatorId, CancellationToken cancellationToken);
        public Task<List<FinalRegistrationDto>> Get(int ActivityId, CancellationToken cancellationToken);

        public Task Delete(int FinalRegistrationId, int PersonDeletedId, CancellationToken cancellationToken);
    }
}
