

namespace App.Domain.Core.Activity.Entities
{
    public class PreRegistration
    {
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public required Activity Activity { get; set; }

        public DateTime? CreatedDateTime { get; set; }

        public int PersonId { get; set; }
        public int ResponsibilityId { get; set; }
        public virtual required Responsibility Responsibility { get; set; }
        public int PersonCreatorId { get; set; }

    }
}
