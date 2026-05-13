using System.ComponentModel.DataAnnotations;

namespace CurriculumMaker.Core.Models;

public sealed class Skill
{
    public Skill() { }

    public Skill(string description)
    {
        Description = description;
    }

    public int Id { get; set; }
    [Required] public string Description { get; set; } = string.Empty;
}