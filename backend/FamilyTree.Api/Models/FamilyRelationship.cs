namespace FamilyTree.Api.Models;

public class FamilyRelationship
{
    public int Id { get; set; }

    public int SubjectMemberId { get; set; }

    public int RelatedMemberId { get; set; }

    public RelationshipType RelationshipType { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }
    
    public string? Notes { get; set; }
}