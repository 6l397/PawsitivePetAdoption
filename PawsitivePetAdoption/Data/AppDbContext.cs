using Microsoft.EntityFrameworkCore;
using PawsitivePetAdoption.Model;

namespace PawsitivePetAdoption.Data;

public class AppDbContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public AppDbContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }
    
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlServer(Configuration.GetConnectionString("DbConnectionString"));
    }
    
    public DbSet<Adopters> Adopters { get; set; }
    public DbSet<Animals> Animals { get; set; }
    public DbSet<Adoptions> Adoptions { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Animals>()
            .HasKey(gs => gs.AnimalId);
        modelBuilder.Entity<Adopters>()
            .HasKey(gs => gs.Id);
        modelBuilder.Entity<Adoptions>()
            .HasKey(gs => gs.AdoptionsId);
        
        
        modelBuilder.Entity<Adoptions>()
            .HasOne(ad => ad.Animal)
            .WithMany(a => a.Adoptions)
            .HasForeignKey(ad => ad.AnimalId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Adoptions>()
            .HasOne(ad => ad.Adopter)
            .WithMany(a => a.Adoptions)
            .HasForeignKey(ad => ad.AdopterId)
            .OnDelete(DeleteBehavior.Cascade); 
        
    }
}