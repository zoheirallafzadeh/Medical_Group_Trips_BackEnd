using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Person.Entities
{
    [Table("Document", Schema = "PERSON")]
    public class Document
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
        public required int PersonId { get; set; }
        //[InverseProperty("Documents")]
        public required Person Person { get; set; }

        //[ForeignKey("DocumentID")]
        public int? PersonConfirmationCertificateId { get; set; }
        public PersonConfirmationCertificate? PersonConfirmationCertificate { get; set; }

    }
}
