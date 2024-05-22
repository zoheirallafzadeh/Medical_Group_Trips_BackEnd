using App.Domain.Core.Person.AppServices;
using App.Domain.Core.Person.DTOs.Person;
using App.Domain.Core.Person.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Person
{

    public class PersonAppService : IPersonAppService
    {
        private IPersonService _personServise;

        PersonAppService(IPersonService personService) => _personServise = personService;

        public async Task Add(PersonCreateDto Person, CancellationToken cancellationToken)
        {
            await _personServise.Add(Person,cancellationToken);
        }

        public Task Add(PersonCreateDto Person, List<int> SkillsId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<PersonDto>> Get(int SkillsId, CancellationToken cancellationToken)
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

        public Task Update(PersonWithSkillsDto personWithSkills, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
