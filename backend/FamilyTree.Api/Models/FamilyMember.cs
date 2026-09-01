namespace FamilyTree.Api.Models;

public class FamilyMember
{
    public int Id { get; set; }
    
    public string FirstName {get; set; } = string.Empty;

    public string? MiddleName { get; set; } //? means it can be null and is not required

    public string LastName {get; set; } = string.Empty;

    public string? MaidenName { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public DateOnly? DateOfDeath {get; set; }

    public string? BirthPlace { get; set; }

    public string? Gender { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }
}