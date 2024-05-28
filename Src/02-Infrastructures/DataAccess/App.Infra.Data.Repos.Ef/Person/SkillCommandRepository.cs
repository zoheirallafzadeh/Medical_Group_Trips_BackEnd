

using App.Domain.Core.Person.Data.Repositories;

namespace App.Infra.Data.Repos.Ef.Person
{
    public class SkillCommandRepository : ISkillCommandRepository
    {
        public Task Add(string SkillName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
