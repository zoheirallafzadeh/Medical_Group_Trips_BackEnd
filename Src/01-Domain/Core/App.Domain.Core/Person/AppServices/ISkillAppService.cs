using App.Domain.Core.Person.DTOs.Skill;


namespace App.Domain.Core.Person.AppServices
{
    public interface ISkillAppService
    {
        public Task Add(string SkillName , CancellationToken cancellationToken);
        public Task<List<SkillDto>> Get(CancellationToken cancellationToken);
        public Task<List<SkillDto>> Get(string SearchSkillName , CancellationToken cancellationToken);

    }
}
