namespace FamilyTree.API.Models;

public class FamilyMember
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public DateTime? DateOfBirth { get; set; }

    // Relationships
    public int? ParentId { get; set; }
    public FamilyMember? Parent { get; set; }
    public List<FamilyMember> Children { get; set; } = new();
}