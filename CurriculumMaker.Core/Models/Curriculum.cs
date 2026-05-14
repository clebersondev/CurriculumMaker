using System.ComponentModel.DataAnnotations;
using CurriculumMaker.Core.Abstractions;

namespace CurriculumMaker.Core.Models;

public sealed class Curriculum : IAggregateRoot
{
    [Required] public PersonalData? PersonalData { get; set; }
}