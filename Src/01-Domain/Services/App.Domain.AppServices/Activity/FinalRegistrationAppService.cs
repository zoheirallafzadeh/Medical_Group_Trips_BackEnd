using App.Domain.Core.Activity.AppServices;
using App.Domain.Core.Activity.DTOs;
using App.Domain.Core.Activity.Services;

namespace App.Domain.AppServices.Activity
{
    public class FinalRegistrationAppService : IFinalRegistrationAppService
    {
        private readonly IFinalRegistrationService _finalRegistrationService;
        public FinalRegistrationAppService(IFinalRegistrationService finalRegistrationService) => _finalRegistrationService = finalRegistrationService;
        public async Task Add(int ActivityId, int PersoneId, int ResponsibilityId, int PersonCreatorId, CancellationToken cancellationToken)
        {
            await _finalRegistrationService.Add(ActivityId, PersoneId, ResponsibilityId, PersonCreatorId, cancellationToken);
        }

        public async Task Delete(int FinalRegistrationId, int PersonDeletedId, CancellationToken cancellationToken)
        {
            await _finalRegistrationService.Delete(FinalRegistrationId, PersonDeletedId, cancellationToken);
        }

        public async Task<List<FinalRegistrationDto>> Get(int ActivityId, CancellationToken cancellationToken)
        {
            return await _finalRegistrationService.Get(ActivityId, cancellationToken);
        }
    }
}
