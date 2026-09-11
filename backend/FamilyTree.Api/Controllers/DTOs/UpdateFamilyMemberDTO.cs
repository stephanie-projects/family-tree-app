using System.ComponentModel.DataAnnotations;

namespace FamilyTree.Api.DTOs;

public class UpdateFamilyMemberDTO
{
    [Required]
    [MaxLength(100)]
    public string FirstName { get; set; } = string.Empty;

    [MaxLength(100)]
    public string? MiddleName { get; set; }

    [Required]
    [MaxLength(100)]
    public string LastName { get; set; } = string.Empty;

    [MaxLength(100)]
    public string? MaidenName { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public DateOnly? DateOfDeath { get; set; }

    [MaxLength(150)]
    public string? BirthPlace { get; set; }

    [MaxLength(50)]
    public string? Gender { get; set; }
}