
using App.Domain.Core.Person.Data.Repositories;
using App.Domain.Core.Person.DTOs.Person;

namespace App.Infra.Data.Repos.Ef.Person
{
    public class PersonQueryRepository : IPersonQueryRepository
    {
        public Task<List<PersonDto>> Get(int SkillsIds, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<PersonWithSkillsDto>> GetPersonWithSkills(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<PersonWithSkillsDto>> GetPersonWithSkills(List<int> PersonIds, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<PersonWithSkillsDto>> GetPersonWithSkills(string SearchString, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
