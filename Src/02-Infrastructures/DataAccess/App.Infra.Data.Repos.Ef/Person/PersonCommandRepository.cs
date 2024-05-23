
using App.Domain.Core.Person.Data.Repositories;
using App.Domain.Core.Person.DTOs.Person;

namespace App.Infra.Data.Repos.Ef.Person
{
    public class PersonCommandRepository : IPersonCommandRepository
    {
        public Task Add(PersonCreateDto Person, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Add(PersonCreateDto Person, List<int> SkillsId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task Update(PersonWithSkillsDto personWithSkills, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
