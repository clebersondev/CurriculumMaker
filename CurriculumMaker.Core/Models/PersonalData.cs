using System.ComponentModel.DataAnnotations;

namespace CurriculumMaker.Core.Models;

public sealed class PersonalData
{
    public PersonalData() { }

    public PersonalData(
        string name,
        string surname,
        string email,
        string phoneNumber,
        string address,
        string city,
        string state)
    {
        Name = name;
        Surname = surname;
        Email = email;
        PhoneNumber = phoneNumber;
        Address = address;
        City = city;
        State = state;
    }

    [Required] public string Name { get; set; } = string.Empty;
    [Required] public string Surname { get; set; } = string.Empty;
    [EmailAddress] public string Email { get; set; } = string.Empty;
    [Required] public string PhoneNumber { get; set; } = string.Empty;
    [Required] public string Address { get; set; } = string.Empty;
    [Required] public string City { get; set; } = string.Empty;
    [Required] public string State { get; set; } = string.Empty;

    public string FullName => $"{Name} {Surname}";
    public string FullAddress => $"{Address}, {City}, {State}";
}