using App.Domain.Core.Activity.DTOs;
using App.Domain.Core.Application.Enum;

namespace App.Domain.Core.Activity.Data.Repositories
{
    public interface IResponsibilityCommandRepository
    {
        public Task Add(string EnName, CancellationToken cancellationToken);
        public Task Add(string EnName, int RelevantSkillsId, CancellationToken cancellationToken);
        public Task Add(int ResponsibilityId, TranslateCode translateCode, string Name, CancellationToken cancellationToken);
        public Task Update(ResponsibilityWithTranslationDto responsibilityWithTranslationDto, CancellationToken cancellationToken);
    }
}
