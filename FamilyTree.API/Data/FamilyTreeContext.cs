using Microsoft.EntityFrameworkCore;
using FamilyTree.API.Models;

namespace FamilyTree.API.Data;

public class FamilyTreeContext : DbContext
{
    public FamilyTreeContext(DbContextOptions<FamilyTreeContext> options)
        : base(options) { }

    public DbSet<FamilyMember> FamilyMembers => Set<FamilyMember>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FamilyMember>()
            .HasOne(f => f.Parent)
            .WithMany(f => f.Children)
            .HasForeignKey(f => f.ParentId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}