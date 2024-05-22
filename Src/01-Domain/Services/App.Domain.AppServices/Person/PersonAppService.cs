using App.Domain.Core.Person.AppServices;
using App.Domain.Core.Person.DTOs.Person;
using App.Domain.Core.Person.Services;

namespace App.Domain.AppServices.Person
{

    public class PersonAppService : IPersonAppService
    {
        private IPersonService _personServise;

        PersonAppService(IPersonService personService) => _personServise = personService;

        public async Task Add(PersonCreateDto Person, CancellationToken cancellationToken)
        {
            await _personServise.Add(Person, cancellationToken);
        }

        public async Task Add(PersonCreateDto Person, List<int> SkillsIds, CancellationToken cancellationToken)
        {
            await _personServise.Add(Person, SkillsIds, cancellationToken);
        }

        public async Task<List<PersonDto>> Get(int SkillsId, CancellationToken cancellationToken)
        {
            return await _personServise.Get(SkillsId, cancellationToken);
        }

        public async Task<List<PersonWithSkillsDto>> GetPersonWithSkills(CancellationToken cancellationToken)
        {
            return await _personServise.GetPersonWithSkills(cancellationToken);
        }

        public async Task<List<PersonWithSkillsDto>> GetPersonWithSkills(List<int> PersonIds, CancellationToken cancellationToken)
        {
            return await GetPersonWithSkills(PersonIds, cancellationToken);
        }

        public async Task<List<PersonWithSkillsDto>> GetPersonWithSkills(string SearchString, CancellationToken cancellationToken)
        {
            return await _personServise.GetPersonWithSkills(SearchString, cancellationToken);
        }

        public async Task Update(PersonWithSkillsDto personWithSkills, CancellationToken cancellationToken)
        {
            await _personServise.Update(personWithSkills, cancellationToken);
        }
    }
}
