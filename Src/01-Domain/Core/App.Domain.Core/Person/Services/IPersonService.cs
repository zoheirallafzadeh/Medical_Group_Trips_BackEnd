

using App.Domain.Core.Person.DTOs.Person;

namespace App.Domain.Core.Person.Services
{
    public interface IPersonService
    {
        public Task Add(PersonCreateDto Person, CancellationToken cancellationToken);
        public Task Add(PersonCreateDto Person, List<int> SkillsId, CancellationToken cancellationToken);
        public Task Update(PersonWithSkillsDto personWithSkills, CancellationToken cancellationToken);
        public Task<List<PersonDto>> Get(int SkillsIds, CancellationToken cancellationToken);
        public Task<List<PersonWithSkillsDto>> GetPersonWithSkills(CancellationToken cancellationToken);
        public Task<List<PersonWithSkillsDto>> GetPersonWithSkills(List<int> PersonIds, CancellationToken cancellationToken);
        public Task<List<PersonWithSkillsDto>> GetPersonWithSkills(string SearchString, CancellationToken cancellationToken);
    }
}
