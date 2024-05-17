using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Person.Entities
{
    [Table("Skill", Schema = "PERSON")]
    public class Skill

    {

        public int Id { get; set; }

        [Unicode(false)]
        public required string Name { get; set; }

        //[InverseProperty("Skill")]
        public virtual List<SkillTranslate>? SkillTranslate { get; } = new();
        //[InverseProperty("Skills")]
        public virtual List<Person>? Persons { get; set; } = new();
        public int? TypeOfMedicalCertificateId { get; set; }
        public TypeOfMedicalCertificate? TypeOfMedicalCertificate { get; set; }

        public int? PersonConfirmationCertificateId { get; set; }
        public virtual PersonConfirmationCertificate? PersonConfirmationCertificate { get; set; }

    }
}
