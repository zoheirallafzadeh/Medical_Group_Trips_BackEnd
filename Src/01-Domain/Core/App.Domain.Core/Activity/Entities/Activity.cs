using Microsoft.EntityFrameworkCore;


namespace App.Domain.Core.Activity.Entities
{
    public class Activity
    {
        public int Id { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }

        [Comment("Place of service")]
        public int AreaId { get; set; }

        public virtual List<PreRegistration>? PreRegistrations { get; set; }
        public virtual List<FinalRegistration>? FinalRegistrations { get; set;}

    }
}
