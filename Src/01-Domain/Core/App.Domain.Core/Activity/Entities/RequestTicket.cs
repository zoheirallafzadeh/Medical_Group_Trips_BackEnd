using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace App.Domain.Core.Activity.Entities
{
    [Table("RequestTicket", Schema = "ACTIVITY")]
    public class RequestTicket
    {
        public int Id { get; set; }
        public int FinalRegistrationId { get; set; }
        public required FinalRegistration FinalRegistration { get; set; }
        public required int PersonId { get; set; }
        public required int CreatedPersonId { get; set; }
        public DateTime CreatedTime { get; set; }

        public bool IsDeleted { get; set; }
        public int DeletedPersonId { get; set; }

        public DateOnly DataRequest {  get; set; }
        [MaxLength(100)]
        //[Comment("آخرین پرواز، ... ")]
        public string? Description { get; set; }


    }
}
