using App.Domain.Core.Application.Enum;

namespace App.Domain.Core.Activity.DTOs
{
    public class ResponsibilityTRDto
    {
        public int? Id { get; set; }
        public int ResponsibilityId { get; set; }
        public required string Name { get; set; }
        public required TranslateCode translateCode { get; set; }
        public int? RelevantSkillsId { get; set; }
        
        
    }
}
