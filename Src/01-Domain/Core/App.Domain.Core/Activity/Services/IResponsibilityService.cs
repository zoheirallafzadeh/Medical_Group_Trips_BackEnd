using App.Domain.Core.Activity.DTOs;
using App.Domain.Core.Application.Enum;


namespace App.Domain.Core.Activity.Services
{
    public interface IResponsibilityService
    {
        public Task Add(string EnName, CancellationToken cancellationToken);
        public Task Add(string EnName, int RelevantSkillsId, CancellationToken cancellationToken);
        public Task Add(int ResponsibilityId, TranslateCode translateCode, string Name, CancellationToken cancellationToken);
        public Task Update(ResponsibilityWithTranslationDto responsibilityWithTranslationDto, CancellationToken cancellationToken);

        public Task<ResponsibilityDto> Get(int ResponsibilityId, CancellationToken cancellationToken);
        public Task<ResponsibilityTRDto> Get(int ResponsibilityId, TranslateCode translateCode, CancellationToken cancellationToken);
        public Task<List<ResponsibilityDto>> Get(CancellationToken cancellationToken);
        public Task<List<ResponsibilityTRDto>> Get(TranslateCode translateCode, CancellationToken cancellationToken);
        public Task<List<ResponsibilityDto>> Get(List<int> ResponsibilityIds, CancellationToken cancellationToken);
        public Task<List<ResponsibilityTRDto>> Get(TranslateCode translateCode, List<int> ResponsibilityIds, CancellationToken cancellationToken);



    }
}
