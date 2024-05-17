using App.Domain.Core.Activity.Enum;
using System.ComponentModel.DataAnnotations.Schema;


namespace App.Domain.Core.Activity.Entities
{
    [Table("Transportation", Schema = "ACTIVITY")]
    public class Transportation
    {
        public int Id { get; set; }
        public int StartTransportationAreaId { get; set; }
        public int EndTransportationAreaId { get; set; }
        public required DateTime startDateTime { get; set; }
        public required TypeOfTransportation TypeOfTransportation { get; set; }
        public string? Description { get; set; }

        public virtual List<Ticket>? Tickets { get; set; }
        public int ActivityId { get; set; }
        public virtual required Activity Activity { get; set; }
    }
}
