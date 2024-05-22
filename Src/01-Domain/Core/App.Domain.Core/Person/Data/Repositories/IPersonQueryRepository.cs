

using App.Domain.Core.Person.DTOs.Person;

namespace App.Domain.Core.Person.Data.Repositories
{
    public interface IPersonQueryRepository
    {
        public Task<List<PersonDto>> Get(int SkillsIds, CancellationToken cancellationToken);
        public Task<List<PersonWithSkillsDto>> GetPersonWithSkills(CancellationToken cancellationToken);
        public Task<List<PersonWithSkillsDto>> GetPersonWithSkills(List<int> PersonIds, CancellationToken cancellationToken);
        public Task<List<PersonWithSkillsDto>> GetPersonWithSkills(string SearchString, CancellationToken cancellationToken);
    }
}
