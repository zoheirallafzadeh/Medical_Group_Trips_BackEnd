
using App.Domain.Core.Person.Data.Repositories;
using App.Domain.Core.Person.DTOs.Skill;

namespace App.Infra.Data.Repos.Ef.Person
{
    public class SkillQueryRepository : ISkillQueryRepository
    {
        public Task<List<SkillDto>> Get(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<SkillDto>> Get(string SearchSkillName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
