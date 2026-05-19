using System.ComponentModel.DataAnnotations;

namespace CurriculumMaker.Core.Models;

public sealed class Language
{
    public Language() { }

    public Language(
        string languageName,
        string proficiency)
    {
        LanguageName = languageName;
        Proficiency = proficiency;
    }

    [Required] public string LanguageName { get; set; } = string.Empty;
    [Required] public string Proficiency { get; set; } = string.Empty;
}