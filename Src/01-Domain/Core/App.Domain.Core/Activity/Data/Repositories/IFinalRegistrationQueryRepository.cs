using App.Domain.Core.Activity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Activity.Data.Repositories
{
    public interface IFinalRegistrationQueryRepository
    {
        public Task<List<FinalRegistrationDto>> Get(int ActivityId, CancellationToken cancellationToken);
    }
}
