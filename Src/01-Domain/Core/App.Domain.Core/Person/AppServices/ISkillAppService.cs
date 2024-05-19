using App.Domain.Core.Person.DTOs.Skill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Person.AppServices
{
    public interface ISkillAppService
    {
        public Task Add(string SkillName , CancellationToken cancellationToken);
        public Task<List<SkillDto>> Get(CancellationToken cancellationToken);
        public Task<List<SkillDto>> Get(string SearchSkillName , CancellationToken cancellationToken);

    }
}
