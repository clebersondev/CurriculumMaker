using System.ComponentModel.DataAnnotations;
using CurriculumMaker.Core.Abstractions;

namespace CurriculumMaker.Core.Models;

public sealed class Curriculum : IAggregateRoot
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Model name is required.")]
    [StringLength(50)]
    public required string ModelName { get; set; } = string.Empty;

    [Required] public required PersonalData PersonalData { get; set; }
    public List<WorkExperience> WorkExperiences { get; set; } = [];
    public List<AcademicBackground> AcademicBackgrounds { get; set; } = [];
    public List<Language> Languages { get; set; } = [];
    public List<Skill> Skills { get; set; } = [];
}