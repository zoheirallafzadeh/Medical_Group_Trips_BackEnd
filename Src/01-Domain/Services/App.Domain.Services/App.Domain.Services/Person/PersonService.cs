
using App.Domain.Core.Person.Data.Repositories;
using App.Domain.Core.Person.DTOs.Person;
using App.Domain.Core.Person.Services;

namespace App.Domain.Services.Person
{
    public class PersonService : IPersonService
    {
        private readonly IPersonCommandRepository _commandRepository;
        private readonly IPersonQueryRepository _queryRepository;
        public PersonService(IPersonCommandRepository commandRepository, IPersonQueryRepository queryRepository)
        {
            _commandRepository = commandRepository;
            _queryRepository = queryRepository;
        }

        public async Task Add(PersonCreateDto Person, CancellationToken cancellationToken)
        {
            await _commandRepository.Add(Person , cancellationToken);
        }

        public async Task Add(PersonCreateDto Person, List<int> SkillsId, CancellationToken cancellationToken)
        {
            await _commandRepository.Add(Person , SkillsId , cancellationToken);
        }

        public async Task<List<PersonDto>> Get(int SkillsIds, CancellationToken cancellationToken)
        {
            return await _queryRepository.Get(SkillsIds, cancellationToken);
        }

        public async Task<List<PersonWithSkillsDto>> GetPersonWithSkills(CancellationToken cancellationToken)
        {
            return await _queryRepository.GetPersonWithSkills(cancellationToken);
        }

        public async Task<List<PersonWithSkillsDto>> GetPersonWithSkills(List<int> PersonIds, CancellationToken cancellationToken)
        {
            return await _queryRepository.GetPersonWithSkills(PersonIds, cancellationToken);
        }

        public async Task<List<PersonWithSkillsDto>> GetPersonWithSkills(string SearchString, CancellationToken cancellationToken)
        {
            return await _queryRepository.GetPersonWithSkills(SearchString, cancellationToken);
        }

        public async Task Update(PersonWithSkillsDto personWithSkills, CancellationToken cancellationToken)
        {
            await Update(personWithSkills, cancellationToken);
        }
    }
}
