using App.Domain.Core.Activity.DTOs;
using App.Domain.Core.Application.Enum;

namespace App.Domain.Core.Activity.Data.Repositories
{
    public interface IResponsibilityQueryRepository
    {
        public Task<ResponsibilityDto> Get(int ResponsibilityId, CancellationToken cancellationToken);
        public Task<ResponsibilityTRDto> Get(int ResponsibilityId, TranslateCode translateCode, CancellationToken cancellationToken);
        public Task<List<ResponsibilityDto>> Get(CancellationToken cancellationToken);
        public Task<List<ResponsibilityTRDto>> Get(TranslateCode translateCode, CancellationToken cancellationToken);
        public Task<List<ResponsibilityDto>> Get(List<int> ResponsibilityIds, CancellationToken cancellationToken);
        public Task<List<ResponsibilityTRDto>> Get(TranslateCode translateCode, List<int> ResponsibilityIds, CancellationToken cancellationToken);
    }
}
