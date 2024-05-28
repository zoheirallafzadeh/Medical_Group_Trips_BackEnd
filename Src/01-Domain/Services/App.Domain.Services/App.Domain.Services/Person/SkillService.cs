
using App.Domain.Core.Person.Data.Repositories;
using App.Domain.Core.Person.DTOs.Skill;
using App.Domain.Core.Person.Services;

namespace App.Domain.Services.Person
{
    public class SkillService : ISkillService
    {
        private readonly ISkillQueryRepository _SkillQueryRepository;
        private readonly ISkillCommandRepository _SkillCommandRepository;
        public SkillService(ISkillQueryRepository queryRepository, ISkillCommandRepository commandRepository)
        {
            _SkillQueryRepository = queryRepository;
            _SkillCommandRepository = commandRepository;
        }

        public async Task Add(string SkillName, CancellationToken cancellationToken)
        {
            await _SkillCommandRepository.Add(SkillName, cancellationToken);
        }

        public async Task<List<SkillDto>> Get(CancellationToken cancellationToken)
        {
            return await _SkillQueryRepository.Get(cancellationToken);
        }

        public Task<List<SkillDto>> Get(string SearchSkillName, CancellationToken cancellationToken)
        {
            return _SkillQueryRepository.Get(SearchSkillName, cancellationToken);
        }
    }
}
