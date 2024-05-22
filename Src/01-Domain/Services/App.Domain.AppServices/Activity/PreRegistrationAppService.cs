using App.Domain.Core.Activity.AppServices;
using App.Domain.Core.Activity.DTOs;
using App.Domain.Core.Activity.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Activity
{
    
    public class PreRegistrationAppService : IPreRegistrationAppService
    {
        private readonly IPreRegistrationService _preRegistrationService;
        public PreRegistrationAppService(IPreRegistrationService preRegistrationService) => _preRegistrationService = preRegistrationService;
        public async Task Add(int ActivityId, int PersoneId, int ResponsibilityId, int PersonCreatorId, CancellationToken cancellationToken)
        {
            await _preRegistrationService.Add(ActivityId, PersoneId, ResponsibilityId, PersonCreatorId, cancellationToken);
        }

        public async Task Delete(int PreRegisterationId, int PersonDeletedId, CancellationToken cancellationToken)
        {
            await _preRegistrationService.Delete(PreRegisterationId, PersonDeletedId, cancellationToken);
        }

        public async Task<List<PreRegistrationDto>> Get(int ActivityId, CancellationToken cancellationToken)
        {
            return await _preRegistrationService.Get(ActivityId, cancellationToken);
        }
    }
}
