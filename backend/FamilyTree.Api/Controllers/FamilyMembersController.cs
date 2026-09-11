using FamilyTree.Api.Data;
using FamilyTree.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FamilyTree.Api.DTOs;

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
        CreateFamilyMemberDTO dto)
    {
        //Creates a new FamilyMember entity based on the data from the CreateFamilyMemberDto and saves it to the database
        var familyMember = new FamilyMember
        {
            FirstName = dto.FirstName,
            MiddleName = dto.MiddleName,
            LastName = dto.LastName,
            MaidenName = dto.MaidenName,
            DateOfBirth = dto.DateOfBirth,
            DateOfDeath = dto.DateOfDeath,
            BirthPlace = dto.BirthPlace,
            Gender = dto.Gender,
            CreatedDate = DateTime.UtcNow,
            UpdatedDate = DateTime.UtcNow
        };

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

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateFamilyMember(
        int id,
        FamilyMember updatedFamilyMember)
    {
        //Checks if the id in the URL matches the id of the updated family member object.
        var existingMember = await _context.FamilyMembers.FindAsync(id);

        if (existingMember == null)
        {
            return NotFound();
        }

        existingMember.FirstName = updatedFamilyMember.FirstName;
        existingMember.MiddleName = updatedFamilyMember.MiddleName;
        existingMember.LastName = updatedFamilyMember.LastName;
        existingMember.MaidenName = updatedFamilyMember.MaidenName;
        existingMember.DateOfBirth = updatedFamilyMember.DateOfBirth;
        existingMember.DateOfDeath = updatedFamilyMember.DateOfDeath;
        existingMember.BirthPlace = updatedFamilyMember.BirthPlace;
        existingMember.Gender = updatedFamilyMember.Gender;
        existingMember.UpdatedDate = DateTime.UtcNow;

        //Marks the existing family member entity as modified and saves the changes to the database
        await _context.SaveChangesAsync();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteFamilyMember(int id)
    {
        var familyMember = await _context.FamilyMembers.FindAsync(id);

        if (familyMember == null)
        {
            return NotFound();
        }

        //Removes the family member entity from the database and saves the changes
        _context.FamilyMembers.Remove(familyMember);

        await _context.SaveChangesAsync();

        return NoContent();
    } 
}