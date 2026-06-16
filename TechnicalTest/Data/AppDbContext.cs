using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using TechnicalTest.Models;

namespace TechnicalTest.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<PlatformDto> Platforms => Set<PlatformDto>();
    public DbSet<WellDto> Wells => Set<WellDto>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PlatformDto>()
            .HasMany(p => p.Wells)
            .WithOne(w => w.Platform)
            .HasForeignKey(w => w.platformId);
    }
}