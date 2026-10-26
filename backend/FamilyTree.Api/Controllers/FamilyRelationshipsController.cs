using FamilyTree.Api.Data;
using FamilyTree.Api.Models;
using FamilyTree.Api.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FamilyTree.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FamilyRelationshipsController : ControllerBase
{
    private readonly FamilyTreeDbContext _context;

    public FamilyRelationshipsController(FamilyTreeDbContext context)
    {
        // Initializes the FamilyRelationshipsController with a database context for accessing family relationships data
        _context = context;
    }


    [HttpPost]
    public async Task<ActionResult<FamilyRelationshipResponseDto>> CreateFamilyRelationship(
        CreateFamilyRelationshipDto dto)
    {
        var subjectExists = await _context.FamilyMembers
        .AnyAsync(member => member.Id == dto.SubjectMemberId);

        var relatedExists = await _context.FamilyMembers
            .AnyAsync(member => member.Id == dto.RelatedMemberId);

        if (!subjectExists || !relatedExists)
        {
            return BadRequest("One or both family members do not exist.");
        }

        if(dto.SubjectMemberId == dto.RelatedMemberId)
        {
            return BadRequest("A family member cannot have a relationship with themselves.");
        }

        var relationship = new FamilyRelationship
        {
            SubjectMemberId = dto.SubjectMemberId,
            RelatedMemberId = dto.RelatedMemberId,
            RelationshipType = dto.RelationshipType
        };

        _context.FamilyRelationships.Add(relationship);
        await _context.SaveChangesAsync();

        var response = new FamilyRelationshipResponseDto
        {
            Id = relationship.Id,
            SubjectMemberId = relationship.SubjectMemberId,
            RelatedMemberId = relationship.RelatedMemberId,
            RelationshipType = relationship.RelationshipType
        };

        return StatusCode(201, response); // Returns a 201 Created response with the created relationship
    }

    
    [HttpGet("{id}")]
    public async Task<ActionResult<FamilyRelationshipResponseDto>> GetFamilyRelationship(int id)
    {
        var relationship = await _context.FamilyRelationships.FindAsync(id);

        if (relationship == null)
        {
            return NotFound();
        }

        var response = new FamilyRelationshipResponseDto
        {
            Id = relationship.Id,
            SubjectMemberId = relationship.SubjectMemberId,
            RelatedMemberId = relationship.RelatedMemberId,
            RelationshipType = relationship.RelationshipType
        };

        return Ok(response);
    }

}