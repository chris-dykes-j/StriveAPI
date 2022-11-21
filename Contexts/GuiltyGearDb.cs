using Microsoft.EntityFrameworkCore;
using StriveAPI.Entities;

namespace StriveAPI.Contexts;

public class GuiltyGearDb : DbContext
{
    public GuiltyGearDb(DbContextOptions<GuiltyGearDb> options) : base(options) { }
    public DbSet<StriveCharacter> StriveCharacters { get; set; } = null!;
    public DbSet<StriveMove> StriveMoves { get; set; } = null!;
}