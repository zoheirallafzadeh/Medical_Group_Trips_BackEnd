using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Activity.AppServices
{
    public interface ActivityAppService
    {
        public Task Add (DateOnly StartDate , DateOnly EndDate ,CancellationToken cancellationToken ,int? AreaId );


    }
}
