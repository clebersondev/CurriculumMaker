using System.ComponentModel.DataAnnotations;

namespace CurriculumMaker.Core.Models;

public sealed class AcademicBackground
{
    public AcademicBackground() { }

    public AcademicBackground(
        string institution,
        string degree,
        string graduationYear,
        string? description = null
    )
    {
        Institution = institution;
        Degree = degree;
        GraduationYear = graduationYear;
        Description = description;
    }

    [Required] public string Institution { get; set; } = string.Empty;
    [Required] public string Degree { get; set; } = string.Empty;
    [Required] public string GraduationYear { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
}