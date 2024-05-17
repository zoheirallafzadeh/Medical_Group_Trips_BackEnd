using App.Domain.Core.Application.Enum;
using System.ComponentModel.DataAnnotations.Schema;


namespace App.Domain.Core.Activity.Entities
{
    [Table("ResponsibilityTR", Schema = "ACTIVITY")]
    public class ResponsibilityTR
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required TranslateCode Language { get; set; }

        public int ResponsibilityId { get; set; }
        public required Responsibility Responsibility { get; set; }
    }
}
