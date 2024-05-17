using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace App.Domain.Core.Area.Entities
{
    [Table("TransportationArea", Schema = "AREA")]
    public class TransportationArea
    {
        public int Id { get; set; }
        [MaxLength(32)]
        public required string EnName { get; set; }
        [MaxLength(32)]
        public required string Name { get; set; }
        public int ZoneId { get; set; }
        public virtual required Zone Zone { get; set; }
    }
}
