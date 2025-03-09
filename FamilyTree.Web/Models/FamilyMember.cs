namespace FamilyTree.Web.Models
{
    public class FamilyMember
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime? DateOfBirth { get; set; }
        public int? ParentId { get; set; }
        public List<FamilyMember> Children { get; set; } = new();
    }
}
