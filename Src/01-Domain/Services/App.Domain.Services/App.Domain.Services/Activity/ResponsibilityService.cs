using App.Domain.Core.Activity.Data.Repositories;
using App.Domain.Core.Activity.DTOs;
using App.Domain.Core.Activity.Services;
using App.Domain.Core.Application.Enum;

namespace App.Domain.Services.Activity
{
    public class ResponsibilityService : IResponsibilityService
    {
        private readonly IResponsibilityCommandRepository _responsibilityCommandRepository;
        private readonly IResponsibilityQueryRepository _responsibilityQueryRepository;
        public ResponsibilityService(IResponsibilityCommandRepository commandRepository, IResponsibilityQueryRepository queryRepository)
        {
            _responsibilityCommandRepository = commandRepository;
            _responsibilityQueryRepository = queryRepository;
        }

        public async Task Add(string EnName, CancellationToken cancellationToken)
        {
            await _responsibilityCommandRepository.Add(EnName, cancellationToken);
        }

        public async Task Add(string EnName, int RelevantSkillsId, CancellationToken cancellationToken)
        {
            await _responsibilityCommandRepository.Add(EnName ,RelevantSkillsId , cancellationToken);
        }

        public async Task Add(int ResponsibilityId, TranslateCode translateCode, string Name, CancellationToken cancellationToken)
        {
            await _responsibilityCommandRepository.Add(ResponsibilityId , translateCode , Name, cancellationToken);
        }

        public async Task<ResponsibilityDto> Get(int ResponsibilityId, CancellationToken cancellationToken)
        {
            return await _responsibilityQueryRepository.Get(ResponsibilityId, cancellationToken);
        }

        public async Task<ResponsibilityTRDto> Get(int ResponsibilityId, TranslateCode translateCode, CancellationToken cancellationToken)
        {
            return await _responsibilityQueryRepository.Get(ResponsibilityId, translateCode, cancellationToken);
        }

        public async Task<List<ResponsibilityDto>> Get(CancellationToken cancellationToken)
        {
            return await _responsibilityQueryRepository.Get(cancellationToken);
        }

        public Task<List<ResponsibilityTRDto>> Get(TranslateCode translateCode, CancellationToken cancellationToken)
        {
            return _responsibilityQueryRepository.Get(translateCode , cancellationToken);
        }

        public Task<List<ResponsibilityDto>> Get(List<int> ResponsibilityIds, CancellationToken cancellationToken)
        {
            return _responsibilityQueryRepository.Get(ResponsibilityIds , cancellationToken);
        }

        public Task<List<ResponsibilityTRDto>> Get(TranslateCode translateCode, List<int> ResponsibilityIds, CancellationToken cancellationToken)
        {
            return _responsibilityQueryRepository.Get(translateCode , ResponsibilityIds , cancellationToken) ;
        }

        public async Task Update(ResponsibilityWithTranslationDto responsibilityWithTranslationDto, CancellationToken cancellationToken)
        {
            await _responsibilityCommandRepository.Update(responsibilityWithTranslationDto , cancellationToken);
        }
    }
}
