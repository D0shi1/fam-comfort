using fam_comfort.Core.Models;
using fam_comfort.Persistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace fam_comfort.Persistence;

public class FamComfortDbContext(DbContextOptions<FamComfortDbContext> options) : DbContext(options)
{
    public DbSet<Facade> Facades { get; set; }
    public DbSet<Catalog> Catalogs { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Decor> Decors { get; set; }
    public DbSet<Color> Colors { get; set; }
    public DbSet<FacadeCategory> FacadesCategories { get; set; }
    public DbSet<DecorCategory> DecorsCategories { get; set; }
    public DbSet<User> Users { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new FacadeCategoryConfiguration());
        modelBuilder.ApplyConfiguration(new DecorCategoryConfiguration());
        modelBuilder.ApplyConfiguration(new FacadeConfiguration());
        modelBuilder.ApplyConfiguration(new DecorConfiguration());
        modelBuilder.ApplyConfiguration(new ColorConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new CatalogConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new ProductConfiguration());
        
        base.OnModelCreating(modelBuilder);
    }
}