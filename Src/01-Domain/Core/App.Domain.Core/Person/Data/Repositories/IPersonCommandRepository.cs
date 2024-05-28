

using App.Domain.Core.Person.DTOs.Person;

namespace App.Domain.Core.Person.Data.Repositories
{
    public interface IPersonCommandRepository
    {
        public Task Add(PersonCreateDto Person, CancellationToken cancellationToken);
        public Task Add(PersonCreateDto Person, List<int> SkillsId, CancellationToken cancellationToken);
        public Task Update(PersonWithSkillsDto personWithSkills, CancellationToken cancellationToken);

    }
}
