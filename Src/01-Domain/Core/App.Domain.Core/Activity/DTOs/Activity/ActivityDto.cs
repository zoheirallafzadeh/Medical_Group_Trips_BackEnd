using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Activity.DTOs.Activity
{
    public class ActivityDto
    {
        public int Id { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public int? AreaId { get; set; }
        public List<int>? PreRegistrationIds { get; set; }
        public List<int>? FinalRegistrationIds { get; set; }
        public List<int>? TransportationIds { get; set; }
        public bool? IsDone { get; set; }
    }
}
