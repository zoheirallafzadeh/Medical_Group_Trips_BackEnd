using App.Domain.Core.Activity.Entities;
using App.Domain.Core.Application.Enum;

namespace App.Domain.Core.Activity.DTOs
{
    public class ResponsibilityDto
    {
        public int Id { get; set; }
        public required string EnName { get; set; }
        public int? RelevantSkillsId { get; set; }
    }
}
