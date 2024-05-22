

using App.Domain.Core.Activity.DTOs;

namespace App.Domain.Core.Activity.Data.Repositories
{
    public interface IPreRegistrationQueryRepository
    {

        public Task<List<PreRegistrationDto>> Get(int ActivityId, CancellationToken cancellationToken);

    }
}
