using App.Domain.Core.Activity.Data.Repositories;
using App.Domain.Core.Activity.DTOs;
using App.Domain.Core.Activity.Services;

namespace App.Domain.Services.Activity
{
    public class FinalRegistrationService :IFinalRegistrationService
    {
        private readonly IFinalRegistrationQueryRepository _queryRepository;
        private readonly IFinalRegistrationCommandRepository _commandRepository;
        public FinalRegistrationService (IFinalRegistrationCommandRepository finalRegistrationCommandRepository, IFinalRegistrationQueryRepository FinalRegistrationQueryRepository)
        { 
            _commandRepository = finalRegistrationCommandRepository;
            _queryRepository = FinalRegistrationQueryRepository;
        }

        public async Task Add(int ActivityId, int PersoneId, int ResponsibilityId, int PersonCreatorId, CancellationToken cancellationToken)
        {
            await _commandRepository.Add(ActivityId , PersoneId ,ResponsibilityId, PersonCreatorId, cancellationToken);
        }

        public async Task Delete(int FinalRegistrationId, int PersonDeletedId, CancellationToken cancellationToken)
        {
            await _commandRepository.Delete(FinalRegistrationId , PersonDeletedId, cancellationToken);
        }

        public async Task<List<FinalRegistrationDto>> Get(int ActivityId, CancellationToken cancellationToken)
        {
            return await _queryRepository.Get(ActivityId, cancellationToken);
        }
    }
}
