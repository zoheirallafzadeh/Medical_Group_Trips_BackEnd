

using App.Domain.Core.Activity.Data.Repositories;
using App.Domain.Core.Activity.DTOs;
using App.Domain.Core.Activity.Services;

namespace App.Domain.Services.Activity
{
    internal class PreRegistrationService : IPreRegistrationService
    {
        private readonly IPreRegistrationQueryRepository _preRegistrationQueryRepository;
        private readonly IPreRegistrationCommandRepository _preRegistrationCommandRepository;
        public PreRegistrationService(IPreRegistrationCommandRepository preRegistrationCommandRepository, IPreRegistrationQueryRepository preRegistrationQueryRepository)
        {
            _preRegistrationCommandRepository = preRegistrationCommandRepository;
            _preRegistrationQueryRepository = preRegistrationQueryRepository;
        }

        public async Task Add(int ActivityId, int PersoneId, int ResponsibilityId, int PersonCreatorId, CancellationToken cancellationToken)
        {
            await _preRegistrationCommandRepository.Add(ActivityId, PersoneId, ResponsibilityId, PersonCreatorId, cancellationToken);
        }

        public async Task Delete(int PreRegisterationId, int PersonDeletedId, CancellationToken cancellationToken)
        {
            await _preRegistrationCommandRepository.Delete(PreRegisterationId, PersonDeletedId, cancellationToken);
        }

        public async Task<List<PreRegistrationDto>> Get(int ActivityId, CancellationToken cancellationToken)
        {
            return await _preRegistrationQueryRepository.Get(ActivityId, cancellationToken);
        }
    }
}
