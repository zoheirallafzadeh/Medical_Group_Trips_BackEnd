using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Person.Entities
{
    [Table("TypeOfMedicalCertificate", Schema = "PERSON")]
    public class TypeOfMedicalCertificate
    {
        public int Id { get; set; }
        //[MaxLength(100)]
        public required string Name { get; set; }
        public string? Description { get; set; }
        public List<Skill>? Skills { get; set; }


        public int? PersonConfirmationCertificateId { get; set; }
        public virtual PersonConfirmationCertificate? PersonConfirmationCertificate { get; set; }
    }
}
