using FamilyTree.Api.Data;
using FamilyTree.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FamilyTree.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FamilyMembersController : ControllerBase
{
    private readonly FamilyTreeDbContext _context;

//Constructor
    public FamilyMembersController(FamilyTreeDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<ActionResult<FamilyMember>> CreateFamilyMember(
        FamilyMember familyMember)
    {
        familyMember.CreatedDate = DateTime.UtcNow;
        familyMember.UpdatedDate = DateTime.UtcNow;

//Tracks the new family member entity and saves it to the database
        _context.FamilyMembers.Add(familyMember);
        await _context.SaveChangesAsync();

        return CreatedAtAction(
            nameof(GetFamilyMember),
            new { id = familyMember.Id },
            familyMember
        );
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<FamilyMember>> GetFamilyMember(int id)
    {
        //Finds the family member with the specified id in the database
        var familyMember = await _context.FamilyMembers.FindAsync(id);

        if (familyMember == null)
        {
            return NotFound();
        }

        return Ok(familyMember);
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<FamilyMember>>> GetFamilyMembers()
    {
        //Retrieves all family members from the database and returns them as a list
        var familyMembers = await _context.FamilyMembers.ToListAsync();

        return Ok(familyMembers);
    }
}