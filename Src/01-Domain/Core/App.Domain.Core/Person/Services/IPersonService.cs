using App.Domain.Core.Person.DTOs.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Person.Services
{
    public interface IPersonService
    {
        public Task<PersonDto> Get(int  Id ,CancellationToken cancellationToken);
        public Task<List<PersonDto>> Get( List<int> Ids , CancellationToken cancellationToken);

        public Task<List<PersonDto>> Get(string SearchName, CancellationToken cancellationToken);

        



        public Task Add(PersonCreateDto Person, CancellationToken cancellationToken);
        public Task Add(int PersonId , List<int> SkillsId , CancellationToken cancellationToken);

        public Task Update(PersonDto Person, CancellationToken cancellationToken);
        public Task Update(int PersonId , List<int> SkillsId , CancellationToken cancellationToken);






    }
}
