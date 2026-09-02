using FamilyTree.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace FamilyTree.Api.Data;

public class FamilyTreeDbContext : DbContext //FamilyTreeDbContext class inherits from Entity Framework's DbContext
{
    public FamilyTreeDbContext(DbContextOptions<FamilyTreeDbContext> options) //constructor for FamiltTreeDbContext and options holds the configuration telling EFCore we are using MySQL and the connection of our database and pass it up to the DbContext class we are inheriting from
    : base(options)
    {

    }

    public DbSet<FamilyMember> FamilyMembers { get; set; }

    public DbSet<FamilyRelationship> FamilyRelationships { get; set; }
    //tells EF Core about the collection of entities we want in our database.
}