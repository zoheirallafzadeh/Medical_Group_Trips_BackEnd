
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App.Domain.Core.Person.Entities
{
    [Table("Person", Schema = "PERSON")]
    public class Person
    {
        public int Id { get; set; }

        [StringLength(10)]
        [Unicode(false)]
        public string NationalCode { get; set; } = null!;

        [Unicode(false)]
        [MaxLength(50)]
        public string EnFirstName { get; set; } = null!;

        [Unicode(false)]
        [MaxLength(50)]
        public string EnLastName { get; set; } = null!;

        [MaxLength(50)]
        public string? FirstName { get; set; } = null!;

        [MaxLength(50)]
        public string? LastName { get; set; } = null!;

        public DateOnly? BirthDate { get; set; }

        [StringLength(13)]
        [Unicode(false)]
        public string? MobNumber { get; set; }

        public bool Gender { get; set; }

        public List<Skill>? Skills { get; set; }
        public List<Document>? Documents { get; set; }
    }
}
