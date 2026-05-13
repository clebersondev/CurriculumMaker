using System.ComponentModel.DataAnnotations;

namespace CurriculumMaker.Core.Models;

public sealed class WorkExperience
{
    public WorkExperience() { }

    public WorkExperience(
        string company,
        string position,
        string startDate,
        string endDate,
        string? description = null)
    {
        Company = company;
        Position = position;
        StartDate = startDate;
        EndDate = endDate;
        Description = description;
    }


    public int Id { get; set; }
    [Required] public string Company { get; set; } = string.Empty;
    [Required] public string Position { get; set; } = string.Empty;
    [Required] public string StartDate { get; set; } = string.Empty;
    [Required] public string EndDate { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
}