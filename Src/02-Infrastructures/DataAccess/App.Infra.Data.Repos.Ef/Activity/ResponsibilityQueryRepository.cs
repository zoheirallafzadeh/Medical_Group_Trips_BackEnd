
using App.Domain.Core.Activity.Data.Repositories;
using App.Domain.Core.Activity.DTOs;
using App.Domain.Core.Application.Enum;

namespace App.Infra.Data.Repos.Ef.Activity
{
    public class ResponsibilityQueryRepository : IResponsibilityQueryRepository
    {
        public Task<ResponsibilityDto> Get(int ResponsibilityId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<ResponsibilityTRDto> Get(int ResponsibilityId, TranslateCode translateCode, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResponsibilityDto>> Get(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResponsibilityTRDto>> Get(TranslateCode translateCode, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResponsibilityDto>> Get(List<int> ResponsibilityIds, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResponsibilityTRDto>> Get(TranslateCode translateCode, List<int> ResponsibilityIds, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
