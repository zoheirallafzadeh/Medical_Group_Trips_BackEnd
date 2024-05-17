using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Person.Entities
{
    [Table("PersonConfirmationCertificate", Schema = "PERSON")]
    public class PersonConfirmationCertificate
    {
        public int Id { get; set; }
        public required bool IsConfirmedActive { get; set; }

        //public int PersonId { get; set; }
        public required Person Person { get; set; }

        //public int SkillId { get; set; }
        public required Skill Skill { get; set; }
        //public int TypeOfMedicalCertificateId { get; set; }
        public required TypeOfMedicalCertificate TypeOfMedicalCertificate { get; set; }
        
        //public int DocumentID { get; set; }
        public Document? Document { get; set; }

    }
}
