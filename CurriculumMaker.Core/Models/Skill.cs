using System.ComponentModel.DataAnnotations;

namespace CurriculumMaker.Core.Models;

public sealed class Skill
{
    public Skill() { }

    public Skill(string description)
    {
        Description = description;
    }

    [Required] public string Description { get; set; } = string.Empty;
}