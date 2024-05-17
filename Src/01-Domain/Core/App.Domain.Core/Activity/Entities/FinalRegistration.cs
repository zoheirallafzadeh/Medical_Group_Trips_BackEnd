using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain.Core.Activity.Entities
{
    [Table("FinalRegistration", Schema = "ACTIVITY")]
    public class FinalRegistration
    {
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public required Activity Activity { get; set; }

        public DateTime? CreatedDateTime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public bool IsDeleted { get; set; }

        public int PersonId { get; set; }
        public int ResponsibilityId { get; set; }
        public virtual required Responsibility Responsibility { get; set; }
        public int PersonCreatorId { get; set; }

        public virtual List<RequestTicket>? RequestTickets { get; set; } = new();

        public int? NumberOfPatient { get; set; }


    }
}
