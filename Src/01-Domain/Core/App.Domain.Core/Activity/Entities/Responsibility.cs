
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain.Core.Activity.Entities
{
    [Table("Responsibility", Schema = "ACTIVITY")]
    public class Responsibility
    {
        public int Id { get; set; }
        public required string EnName { get; set; }
        public int RelevantSkillsId { get; set; }
        public List<ResponsibilityTR>? ResponsibilityTRs { get; set;}

        public virtual List<PreRegistration>? PreRegistrations { get; set; }
        public virtual List<FinalRegistration>? FinalRegistrations { get; set;}

    }
}
