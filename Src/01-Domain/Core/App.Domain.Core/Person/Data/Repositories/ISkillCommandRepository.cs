
using App.Domain.Core.Person.DTOs.Skill;

namespace App.Domain.Core.Person.Data.Repositories
{
    public interface ISkillCommandRepository
    {
        public Task Add(string SkillName, CancellationToken cancellationToken);

    }
}
