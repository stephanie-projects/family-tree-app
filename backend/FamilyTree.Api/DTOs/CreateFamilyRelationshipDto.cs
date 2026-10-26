using System.ComponentModel.DataAnnotations;
using FamilyTree.Api.Models;

namespace FamilyTree.Api.DTOs;

public class CreateFamilyRelationshipDto
{
    [Range(1, int.MaxValue)]
    public int SubjectMemberId { get; set; }

    [Range(1, int.MaxValue)]
    public int RelatedMemberId { get; set; }

    [Required]
    public RelationshipType RelationshipType { get; set; }
}