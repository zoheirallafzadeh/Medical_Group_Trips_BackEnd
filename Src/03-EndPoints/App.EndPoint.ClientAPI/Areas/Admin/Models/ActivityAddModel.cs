namespace App.EndPoint.ClientAPI.Areas.Admin.Models
{
    public class ActivityAddModel
    {
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public int? AreaId { get; set; }
    }
}
