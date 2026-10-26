
using FamilyTree.Api.Models;

namespace FamilyTree.Api.DTOs;


// <summary>
// Represents a response DTO for family relationships.
// </summary>
public class FamilyRelationshipResponseDto
{
    public int Id { get; set; }

// the member who has the specified relationship to the other member
    public int SubjectMemberId { get; set; }

// the member that relationship refers to
    public int RelatedMemberId { get; set; }

    public RelationshipType RelationshipType { get; set; }
}
//Example James is Robert's parent, James's ID would be subjectMemberId, Robert's ID would be relatedMemberId, and the relationshipType would be Parent.
