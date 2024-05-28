
using App.Domain.Core.Activity.Data.Repositories;
using App.Domain.Core.Activity.DTOs;
using App.Domain.Core.Application.Enum;

namespace App.Infra.Data.Repos.Ef.Activity
{
    public class ResponsibilityCommandRepository : IResponsibilityCommandRepository
    {
        public Task Add(string EnName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Add(string EnName, int RelevantSkillsId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Add(int ResponsibilityId, TranslateCode translateCode, string Name, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Update(ResponsibilityWithTranslationDto responsibilityWithTranslationDto, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
