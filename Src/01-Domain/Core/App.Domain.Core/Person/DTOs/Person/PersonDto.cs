

namespace App.Domain.Core.Person.DTOs.Person
{
    public class PersonDto
    {
        public int Id { get; set; }
        public string? NationalCode { get; set; }
        public string? EnFirstName { get; set; }
        public string? EnLastName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateOnly? BirthDate { get; set; }
        public string? mobnumber { get; set; }
        public bool? Gender { get; set; }


    }
}
