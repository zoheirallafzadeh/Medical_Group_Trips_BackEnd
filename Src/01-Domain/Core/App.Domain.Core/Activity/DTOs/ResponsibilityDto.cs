using App.Domain.Core.Activity.Entities;

namespace App.Domain.Core.Activity.DTOs
{
    public class ResponsibilityDto
    {
        public int Id { get; set; }
        public required string EnName { get; set; }
        public int? RelevantSkillsId { get; set; }
        public List<ResponsibilityTR>? ResponsibilityTRs { get; set; }
    }
}
