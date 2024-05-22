using App.Domain.Core.Person.AppServices;
using App.Domain.Core.Person.DTOs.Skill;
using App.Domain.Core.Person.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.AppServices.Person
{
    public class SkillAppService : ISkillAppService
    {
        private readonly ISkillService _skillService;
        public SkillAppService(ISkillService skillService) => _skillService = skillService;

        public async Task Add(string SkillName, CancellationToken cancellationToken)
        {
            await _skillService.Add(SkillName, cancellationToken);
        }

        public async Task<List<SkillDto>> Get(CancellationToken cancellationToken)
        {
            return await _skillService.Get(cancellationToken);
        }

        public Task<List<SkillDto>> Get(string SearchSkillName, CancellationToken cancellationToken)
        {
            return _skillService.Get(SearchSkillName, cancellationToken);
        }
    }
}
