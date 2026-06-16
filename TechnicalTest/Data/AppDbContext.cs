using Microsoft.EntityFrameworkCore;
using System.Runtime.InteropServices;
using TechnicalTest.Models;

namespace TechnicalTest.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<PlatformDto> Platforms => Set<PlatformDto>();
    public DbSet<WellDto> Wells => Set<WellDto>();
    public DbSet<PlatformDummyDto> PlatformDummy => Set<PlatformDummyDto>();
    public DbSet<WellDummyDto> WellDummy => Set<WellDummyDto>();

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<PlatformDto>()
    //         .HasKey(x => x.id);


    //     modelBuilder.Entity<WellDto>()
    //         .HasKey(x => x.id);


    //     modelBuilder.Entity<PlatformDto>()
    //         .HasMany(x => x.Wells)
    //         .WithOne()
    //         .HasForeignKey(x => x.platformId);
    // }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PlatformDummyDto>()
            .HasKey(x => x.id);

        modelBuilder.Entity<WellDummyDto>()
            .HasKey(x => x.id);

        modelBuilder.Entity<PlatformDummyDto>()
            .HasMany(x => x.Wells)
            .WithOne(x => x.Platform)
            .HasForeignKey(x => x.platformId);
        }
}