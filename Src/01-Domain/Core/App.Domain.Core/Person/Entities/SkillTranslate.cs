using App.Domain.Core.Application.Enum;
using System.ComponentModel.DataAnnotations.Schema;


namespace App.Domain.Core.Person.Entities
{
    [Table("SkillTranslate", Schema = "PERSON")]
    public class SkillTranslate
    {

        public int Id { get; set; }
        public TranslateCode language { get; set; }

        public required string Name { get; set; }
        public bool IsNeedConfirmation { get; set; }
        public int SkillId { get; set; }
        [InverseProperty("")]
        public virtual required Skill Skill { get; set; }
    }
}
