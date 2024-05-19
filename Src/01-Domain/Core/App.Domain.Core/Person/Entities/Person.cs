
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain.Core.Person.Entities
{
    [Table("People", Schema = "PERSON")]
    public class Person
    {
        public int Id { get; set; }

        [StringLength(10)]
        [Unicode(false)]
        public string? NationalCode { get; set; } = null!;

        [Unicode(false)]
        [MaxLength(50)]
        public string? EnFirstName { get; set; } = null!;

        [Unicode(false)]
        [MaxLength(50)]
        public string? EnLastName { get; set; } = null!;

        [MaxLength(50)]
        public string? FirstName { get; set; } = null!;

        [MaxLength(50)]
        public string? LastName { get; set; } = null!;

        public DateOnly? BirthDate { get; set; }

        [StringLength(13)]
        [Unicode(false)]
        public string? mobnumber { get; set; }

        public bool Gender { get; set; }
        public virtual List<Skill>? Skills { get; set; }
        public virtual List<Document>? Documents { get; set; }

        public int? AspNetUsersId { get; set; }
        public List<PersonConfirmationCertificate>? PersonConfirmationCertificates { get; set; }

    }
}
