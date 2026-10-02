using System.ComponentModel.DataAnnotations;
using FamilyTree.Api.Models;

namespace FamilyTree.Api.DTOs;

public class CreateFamilyRelationshipDto
{
    [Required]
    public int SubjectMemberId { get; set; }

    [Required]
    public int RelatedMemberId { get; set; }

    [Required]
    public RelationshipType RelationshipType { get; set; }
}