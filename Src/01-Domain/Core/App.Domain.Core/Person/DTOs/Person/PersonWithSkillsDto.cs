using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Person.DTOs.Person
{
    public class PersonWithSkillsDto
    {
        public string? NationalCode { get; set; }
        public string? EnFirstName { get; set; }
        public string? EnLastName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateOnly? BirthDate { get; set; }
        public string? mobnumber { get; set; }
        public bool? Gender { get; set; }

        public List<int>? SkillsId { get; set; }
    }
}
