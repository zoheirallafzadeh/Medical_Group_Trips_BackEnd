using App.Domain.Core.Activity.AppServices;
using App.Domain.Core.Activity.DTOs;
using App.Domain.Core.Activity.Services;
using App.Domain.Core.Application.Enum;

namespace App.Domain.AppServices.Activity
{
    public class ResponsibilityAppService : IResponsibilityAppService
    {
        private readonly IResponsibilityService _responsibilityService;
        public ResponsibilityAppService(IResponsibilityService responsibilityService) => _responsibilityService = responsibilityService;

        public async Task Add(string EnName, CancellationToken cancellationToken)
        {
            await _responsibilityService.Add(EnName, cancellationToken);
        }

        public async Task Add(string EnName, int RelevantSkillsId, CancellationToken cancellationToken)
        {
            await _responsibilityService.Add(EnName, RelevantSkillsId, cancellationToken);
        }

        public async Task Add(int ResponsibilityId, TranslateCode translateCode, string Name, CancellationToken cancellationToken)
        {
            await _responsibilityService.Add(ResponsibilityId, translateCode, Name, cancellationToken);
        }

        public async Task<ResponsibilityDto> Get(int ResponsibilityId, CancellationToken cancellationToken)
        {
            return await _responsibilityService.Get(ResponsibilityId, cancellationToken);
        }

        public async Task<ResponsibilityTRDto> Get(int ResponsibilityId, TranslateCode translateCode, CancellationToken cancellationToken)
        {
            return await _responsibilityService.Get(ResponsibilityId, translateCode, cancellationToken);
        }

        public async Task<List<ResponsibilityDto>> Get(CancellationToken cancellationToken)
        {
            return await _responsibilityService.Get(cancellationToken);
        }

        public async Task<List<ResponsibilityTRDto>> Get(TranslateCode translateCode, CancellationToken cancellationToken)
        {
            return await _responsibilityService.Get(translateCode, cancellationToken);
        }

        public async Task<List<ResponsibilityDto>> Get(List<int> ResponsibilityIds, CancellationToken cancellationToken)
        {
            return await _responsibilityService.Get(ResponsibilityIds, cancellationToken);
        }

        public async Task<List<ResponsibilityTRDto>> Get(TranslateCode translateCode, List<int> ResponsibilityIds, CancellationToken cancellationToken)
        {
            return await _responsibilityService.Get(translateCode, ResponsibilityIds, cancellationToken);
        }

        public async Task Update(ResponsibilityWithTranslationDto responsibilityWithTranslationDto, CancellationToken cancellationToken)
        {
            await Update(responsibilityWithTranslationDto, cancellationToken);
        }
    }
}
