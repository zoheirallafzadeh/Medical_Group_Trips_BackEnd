using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain.Core.Activity.Entities
{
    [Table("Ticket", Schema = "ACTIVITY")]
    public class Ticket
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int CreatedPersonId { get; set; }
        public DateTime CrearedTime { get; set; }
        public bool IsDeleted { get; set; }
        public int? DeletedPersonId { get; set; }
        public int TransportationId { get; set; }
        public virtual required Transportation Transportation { get; set; }
    }
}
