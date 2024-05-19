namespace App.Domain.Core.Activity.DTOs.Activity
{
    public class ActivityLeastDto
    {
        public int Id { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public int? AreaId { get; set; }
    }
}
