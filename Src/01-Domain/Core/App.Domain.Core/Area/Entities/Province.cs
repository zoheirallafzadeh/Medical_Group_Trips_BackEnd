﻿
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace App.Domain.Core.Area.Entities
{
    [Table("Province", Schema = "AREA")]
    public class Province
    {
        public int Id { get; set; }
        [MaxLength(32)]
        public required string EnName { get; set; }
        [MaxLength(32)]
        public required string Name { get; set; }
        public int CountryId {  get; set; }
        public virtual required Country Country { get; set; }
        public virtual List<Zone>? Zones { get; set; }
    }
}
