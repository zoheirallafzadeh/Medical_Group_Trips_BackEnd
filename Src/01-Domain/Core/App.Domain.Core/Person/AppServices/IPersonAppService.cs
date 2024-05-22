using App.Domain.Core.Person.DTOs.Person;


namespace App.Domain.Core.Person.AppServices
{
    public interface IPersonAppService
    {
       
        public Task Add(PersonCreateDto Person , CancellationToken cancellationToken);
        public Task Add(PersonCreateDto Person, List<int> SkillsId, CancellationToken cancellationToken);
        public Task Update(PersonWithSkillsDto personWithSkills, CancellationToken cancellationToken);
        public Task<List<PersonDto>> Get(int  SkillsId, CancellationToken cancellationToken);
        public Task<List<PersonWithSkillsDto>> GetPersonWithSkills(CancellationToken cancellationToken);
        public Task<List<PersonWithSkillsDto>> GetPersonWithSkills(List<int> PersonIds, CancellationToken cancellationToken);
        public Task<List<PersonWithSkillsDto>> GetPersonWithSkills(string SearchString, CancellationToken cancellationToken);
        //public Task<List<PersonWithSkillsDto>> GetPersonWithSkills(int PersonId, CancellationToken cancellationToken);

        


    }
}
