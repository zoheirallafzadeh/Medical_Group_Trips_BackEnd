
using App.Domain.Core.Person.DTOs.Skill;

namespace App.Domain.Core.Person.Data.Repositories
{
    public interface ISkillQueryRepository
    {
        public Task<List<SkillDto>> Get(CancellationToken cancellationToken);
        public Task<List<SkillDto>> Get(string SearchSkillName, CancellationToken cancellationToken);
    }
}
