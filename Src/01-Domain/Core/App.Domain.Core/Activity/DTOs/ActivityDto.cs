namespace App.Domain.Core.Activity.DTOs
{
    public class ActivityDto
    {
        public int Id { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public int? AreaId { get; set; }
        public bool? IsDone { get; set; }
    }
}
