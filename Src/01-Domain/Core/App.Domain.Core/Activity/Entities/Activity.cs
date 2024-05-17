using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;


namespace App.Domain.Core.Activity.Entities
{
    [Table("Activity", Schema = "ACTIVITY")]
    public class Activity
    {
        public int Id { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }

        [Comment("Place of service")]
        public int AreaId { get; set; }

        public virtual List<PreRegistration>? PreRegistrations { get; set; }
        public virtual List<FinalRegistration>? FinalRegistrations { get; set; }

        //public virtual List<RequestTicket>? RequestTickets { get; set; } = new();

        //public virtual List<Ticket>? Ticket { get; set; }
        public virtual List<Transportation>? Transportations { get; set; }
        public bool IsDone { get; set; }
        public bool IsDeleted { get; set; }



    }
}
