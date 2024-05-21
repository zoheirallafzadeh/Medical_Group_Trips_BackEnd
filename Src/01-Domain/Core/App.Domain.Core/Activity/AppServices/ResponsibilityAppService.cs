using App.Domain.Core.Activity.DTOs;
using App.Domain.Core.Application.Enum;


namespace App.Domain.Core.Activity.AppServices
{
    public interface ResponsibilityAppService
    {
        public Task Add (string EnName , CancellationToken cancellationToken);
        public Task Add(string EnName , int RelevantSkillsId, CancellationToken cancellationToken);
        public Task Add(int Responsibility, TranslateCode translateCode, string Name, CancellationToken cancellationToken);
        public Task Update(ResponsibilityDto responsibilityDto, CancellationToken cancellationToken);

        


        public Task<ResponsibilityDto> Get(int  ResponsibilityId , CancellationToken cancellationToken);
        public Task<List<ResponsibilityDto>> Get(CancellationToken cancellationToken);
        public Task<List<ResponsibilityDto>> Get(List<int> ResponsibilityIds , CancellationToken cancellationToken);
    }
}
