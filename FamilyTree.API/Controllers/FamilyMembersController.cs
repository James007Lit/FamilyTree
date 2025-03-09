using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FamilyTree.API.Data;
using FamilyTree.API.Models;

namespace FamilyTree.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class FamilyMembersController : ControllerBase
{
    private readonly FamilyTreeContext _context;

    public FamilyMembersController(FamilyTreeContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<FamilyMember>>> GetFamilyMembers()
    {
        return await _context.FamilyMembers
            .Include(f => f.Children)
            .ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<FamilyMember>> GetFamilyMember(int id)
    {
        var familyMember = await _context.FamilyMembers
            .Include(f => f.Children)
            .FirstOrDefaultAsync(f => f.Id == id);

        if (familyMember == null)
        {
            return NotFound();
        }

        return familyMember;
    }

    [HttpPost]
    public async Task<ActionResult<FamilyMember>> PostFamilyMember(FamilyMember familyMember)
    {
        _context.FamilyMembers.Add(familyMember);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetFamilyMember), new { id = familyMember.Id }, familyMember);
    }

    // Add PUT and DELETE methods here
}