﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Area.Entities
{
    [Table("Zone", Schema = "AREA")]
    public class Zone
    {
        public int Id { get; set; }
        [MaxLength(32)]
        public required string EnName { get; set; }
        [MaxLength(32)]
        public required string Name { get; set; }
        public int ProvinceId { get; set; }
        public virtual required Province Province { get; set; }
        public virtual List<Area>? Areas { get; set; }
        public virtual List<Airport>? Airports { get; set; }

    }
}
