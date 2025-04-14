using fam_comfort.Core.Models;
using fam_comfort.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace fam_comfort.Persistence;

public class FamComfortDbContext(DbContextOptions<FamComfortDbContext> options) : DbContext(options)
{
    public DbSet<Facade> Facades { get; set; }
    public DbSet<Color> Colors { get; set; }
    public DbSet<FacadeCategory> FacadesCategories { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new FacadeCategoryConfiguration());
        modelBuilder.ApplyConfiguration(new FacadeConfiguration());
        modelBuilder.ApplyConfiguration(new ColorConfiguration());
        
        base.OnModelCreating(modelBuilder);
    }
}