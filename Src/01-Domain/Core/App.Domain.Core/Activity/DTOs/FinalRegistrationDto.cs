

namespace App.Domain.Core.Activity.DTOs
{
    public class FinalRegistrationDto
    {
        public int Id { get; set; }
        public int ActivityId { get; set; }
        public int PersonId { get; set; }
        public int ResponsibilityId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
